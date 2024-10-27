using FdxSharp.Enums;
using FdxSharp.OAuth;
using FdxSharp.Requests;
using FluentResults;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace FdxSharp
{
	/// <summary>
	/// Concrete implementation of the FdxClient interface
	/// </summary>
	public class FdxClient : IFdxClient
	{
		private readonly ILogger<FdxClient> _logger;
		private readonly IHttpClientFactory _factory;
		private IOptions<FdxClientOptions> _options;
		private IOAuthClient _authClient;

		/// <summary>
		/// Creates a new instance of the <see cref="FdxClient"/>
		/// </summary>
		/// <param name="factory">Used to create HttpClient objects.</param>
		/// <param name="logger">Logging system</param>
		/// <param name="options">Options for the FdxClient</param>
		/// <param name="authClient">Authentication implementation for OAuth 2.0</param>
		/// <exception cref="ArgumentNullException"></exception>
		public FdxClient(IHttpClientFactory factory, ILogger<FdxClient> logger, IOptions<FdxClientOptions> options,
			IOAuthClient authClient)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_options = options ?? throw new ArgumentNullException(nameof(options));
			_authClient = authClient ?? throw new ArgumentNullException(nameof(authClient));
		}

		/// <inheritdoc />
		public IFdxClient WithOptions(IOptions<FdxClientOptions> options)
		{
			_options = options;
			return this;
		}

		/// <inheritdoc />
		public async Task<Result<CreateTaxFormResponse>> CreateTaxFormAsync(CreateTaxFormRequest request, CancellationToken cancellationToken = default)
		{
			try
			{
				var tokenResult = await _authClient.GetTokenAsync(new OAuthClientCredentialsRequest
				{
					TokenUrl = _options.Value.OAuthTokenUrl,
					ClientId = _options.Value.OAuthClientId,
					ClientSecret = _options.Value.OAuthClientSecret,
					Scope = _options.Value.OAuthScope
				}, cancellationToken);

				// Check for errors
				if (tokenResult.IsFailed)
					return Result.Fail<CreateTaxFormResponse>(tokenResult.Errors);

				if (string.IsNullOrWhiteSpace(tokenResult.Value.AccessToken))
					return Result.Fail<CreateTaxFormResponse>("No access token returned");

				// Create the request
				using var client = _factory.CreateClient();
				client.BaseAddress = new Uri(_options.Value.BaseUrl);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.Value.AccessToken);
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

				var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/tax-forms")
				{
					Content = JsonContent.Create<TaxDataList>(request, MediaTypeHeaderValue.Parse("application/json"))
				};

				var responseMessage = await client.SendAsync(requestMessage, cancellationToken);

				CreateTaxFormResponse response = new CreateTaxFormResponse();
				if (responseMessage.IsSuccessStatusCode)
				{

					// 201 means the document was created and submitted.
					if (responseMessage.StatusCode == System.Net.HttpStatusCode.Created)
					{
						response.Content = await responseMessage.Content
							.ReadFromJsonAsync<TaxDataList>(cancellationToken);
					}
					// 206 means the document was partially created and submitted but some errors are being returned.
					else if (responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
					{
						response = await ParsePartialSuccessAsync(responseMessage, cancellationToken);
					}
				}

				return Result.Ok(response);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error creating tax form: {0}", ex.Message);
				return Result.Fail<CreateTaxFormResponse>("Error creating tax form");
			}
		}

		/// <inheritdoc />
		public async Task<Result<GetTaxFormResponse>> GetTaxFormAsync(GetTaxFormRequest request, CancellationToken cancellationToken = default)
		{
			try
			{
				var tokenResult = await _authClient.GetTokenAsync(new OAuthClientCredentialsRequest
				{
					TokenUrl = _options.Value.OAuthTokenUrl,
					ClientId = _options.Value.OAuthClientId,
					ClientSecret = _options.Value.OAuthClientSecret,
					Scope = _options.Value.OAuthScope
				}, cancellationToken);

				// Check for errors
				if (tokenResult.IsFailed)
					return Result.Fail<GetTaxFormResponse>(tokenResult.Errors);

				if (string.IsNullOrWhiteSpace(tokenResult.Value.AccessToken))
					return Result.Fail<GetTaxFormResponse>("No access token returned");

				// Create the request
				StringBuilder builder = new();
				builder.Append($"/tax-forms/{request.TaxFormId}");

				if (!string.IsNullOrWhiteSpace(request.AccountId) || !string.IsNullOrWhiteSpace(request.Offset) ||
					request.Limit is not null)
					builder.Append("?");

				if (!string.IsNullOrWhiteSpace(request.AccountId))
					builder.Append($"accountId={request.AccountId}");

				if (!string.IsNullOrWhiteSpace(request.Offset))
					builder.Append($"&offset={request.Offset}");

				if (request.Limit is not null)
					builder.Append($"&limit={request.Limit}");

				var requestMessage = new HttpRequestMessage(HttpMethod.Get, builder.ToString());
				requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.Value.AccessToken);
				requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				using var client = _factory.CreateClient();
				var responseMessage = await client.SendAsync(requestMessage, cancellationToken);

				if (responseMessage.IsSuccessStatusCode)
				{
					var response = new GetTaxFormResponse();
					if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK ||
						responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
					{
						// Determine what the data type is that is being returned.
						if (responseMessage.Content.Headers.ContentType.MediaType == "application/json")
						{
							response.ContentFormat = Enums.ContentType.JSON;
							response.ContentAsJson = await responseMessage.Content.ReadFromJsonAsync<TaxDataList>(cancellationToken);
						}
						else
						{
							response.ContentFormat = responseMessage.Content.Headers.ContentType.MediaType switch
							{
								"image/jpeg" => Enums.ContentType.JPEG,
								"image/png" => Enums.ContentType.PNG,
								"image/gif" => Enums.ContentType.GIF,
								"image/tiff" => Enums.ContentType.TIFF,
								"application/pdf" => Enums.ContentType.PDF
							};
							response.ContentAsBase64 = await responseMessage.Content.ReadAsStringAsync(cancellationToken);
						}
					}
					return Result.Ok(response);
				}
				else
				{
					if (responseMessage.StatusCode == System.Net.HttpStatusCode.NotAcceptable)
						return Result.Fail<GetTaxFormResponse>("Document not available for 'Accept' header's content-type");

					return Result.Fail<GetTaxFormResponse>("Error retrieving tax form");
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error retrieving tax form: {0}", ex.Message);
				return Result.Fail<GetTaxFormResponse>("Error retrieving tax form");
			}
		}

		/// <inheritdoc />
		public async Task<Result<SearchForTaxFormsResponse>> GetTaxFormsAsync(SearchForTaxFormsRequest request, CancellationToken cancellationToken = default)
		{
			try
			{
				var tokenResult = await _authClient.GetTokenAsync(new OAuthClientCredentialsRequest
				{
					TokenUrl = _options.Value.OAuthTokenUrl,
					ClientId = _options.Value.OAuthClientId,
					ClientSecret = _options.Value.OAuthClientSecret,
					Scope = _options.Value.OAuthScope
				}, cancellationToken);

				// Check for errors
				if (tokenResult.IsFailed)
					return Result.Fail<SearchForTaxFormsResponse>(tokenResult.Errors);

				if (string.IsNullOrWhiteSpace(tokenResult.Value.AccessToken))
					return Result.Fail<SearchForTaxFormsResponse>("No access token returned");

				// Build request
				StringBuilder uriBuilder = new();
				uriBuilder.Append("/tax-forms?");

				// IMPORTANT: Field to be removed in FDX version 6.0
				if (request.TaxYears?.Length > 0)
					AppendQueryString(uriBuilder, "taxYears", request.TaxYears.Select(x => x.ToString()).Aggregate((x, y) => $"{x},{y}"));

				if (!string.IsNullOrWhiteSpace(request.AccountId))
					AppendQueryString(uriBuilder, "accountId", request.AccountId);

				if (request.TaxYear is not null)
					AppendQueryString(uriBuilder, "taxYear", request.TaxYear!.ToString());

				if (request.Offset is not null)
					AppendQueryString(uriBuilder, "offset", request.Offset);

				if (request.Limit is not null)
					AppendQueryString(uriBuilder, "limit", request.Limit.ToString());

				if (request.ContentTypes?.Length > 0)
				{
					StringBuilder contentTypeBuilder = new();
					foreach (var ct in request.ContentTypes)
					{
						contentTypeBuilder.Append($"{ContentTypeConverter.GetMimeType(ct)},");
						contentTypeBuilder.Remove(contentTypeBuilder.Length - 1, 1);
					}
					AppendQueryString(uriBuilder, "contentTypes", contentTypeBuilder.ToString());
				}

				if (request.ResultType is not null)
					AppendQueryString(uriBuilder, "resultType", request.ResultType.ToString());

				var requestMessage = new HttpRequestMessage(HttpMethod.Get, uriBuilder.ToString());
				requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.Value.AccessToken);
				requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				using var client = _factory.CreateClient();
				var responseMessage = await client.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);

				if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var response = new SearchForTaxFormsResponse
					{
						Content = await responseMessage.Content.ReadFromJsonAsync<TaxDataList>(cancellationToken)
					};
					return Result.Ok(response);
				}
				else if (responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
				{
					//TODO:  Implement partial success parsing
					throw new NotImplementedException();
				}
				else
				{
					return Result.Fail<SearchForTaxFormsResponse>("Error retrieving tax forms");
				}

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error retrieving tax forms: {0}", ex.Message);
				return Result.Fail<SearchForTaxFormsResponse>("Error retrieving tax forms");
			}
		}

		/// <inheritdoc />
		public Task<Result<UpdateTaxFormResponse>> UpdateTaxFormAsync(UpdateTaxFormRequest request, CancellationToken cancellationToken = default)
		{
			throw new NotImplementedException();
		}

		#region Private Methods

		internal async Task<CreateTaxFormResponse> ParsePartialSuccessAsync(HttpResponseMessage responseMessage, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		private StringBuilder AppendQueryString(StringBuilder builder, string key, string value)
		{
			if (builder[^1] != '?')
				builder.Append("&");
			else
				builder.Append("?");

			builder.Append($"{key}={value}");
			return builder;
		}

		#endregion
	}
}

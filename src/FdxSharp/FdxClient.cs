using FdxSharp.Enums;
using FdxSharp.OAuth;
using FdxSharp.Requests;
using FluentResults;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

#if NET6_0_OR_GREATER
using System.Net.Http.Json;
#elif NETSTANDARD2_0

#endif

namespace FdxSharp
{
	/// <summary>
	/// Concrete implementation of the FdxClient interface
	/// </summary>
	public class FdxClient : IFdxClient
	{
		internal const string JSON_CONTENT_TYPE = "application/json";

		private readonly ILogger<FdxClient> _logger;
		private IOptions<FdxClientOptions> _options;
		private readonly IOAuthClient _authClient;

#if NET6_0_OR_GREATER
		private readonly IHttpClientFactory _factory;

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
#elif NETSTANDARD2_0

		/// <summary>
		/// Creates a new instance of the <see cref="FdxClient"/>
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="options"></param>
		/// <param name="authClient"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public FdxClient(ILogger<FdxClient> logger, IOptions<FdxClientOptions> options, IOAuthClient authClient)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_options = options ?? throw new ArgumentNullException(nameof(options));
			_authClient = authClient ?? throw new ArgumentNullException(nameof(authClient));
		}
#endif

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
#if NET6_0_OR_GREATER
				using var client = _factory.CreateClient();
#elif NETSTANDARD2_0
				using var client = new HttpClient();
#endif
				client.BaseAddress = new Uri(_options.Value.BaseUrl);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.Value.AccessToken);
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JSON_CONTENT_TYPE));
				client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", JSON_CONTENT_TYPE);

				var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/tax-forms");

				// Serialize the request object to JSON (use System.Text.Json for .NET 5.0 and later)
#if NET6_0_OR_GREATER
				requestMessage.Content = JsonContent.Create<TaxDataList>(request, MediaTypeHeaderValue.Parse(JSON_CONTENT_TYPE));
#elif NETSTANDARD2_0
				requestMessage.Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, JSON_CONTENT_TYPE);
#endif

				var responseMessage = await client.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);

				CreateTaxFormResponse response = new CreateTaxFormResponse();
				if (responseMessage.IsSuccessStatusCode)
				{

					// 201 means the document was created and submitted.
					if (responseMessage.StatusCode == System.Net.HttpStatusCode.Created)
					{
#if NET6_0_OR_GREATER
						response.Content = await responseMessage.Content
							.ReadFromJsonAsync<TaxDataList>(cancellationToken);
#elif NETSTANDARD2_0

						var json = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
						response.Content = JsonSerializer.Deserialize<TaxDataList>(json);
#endif
					}
					// 206 means the document was partially created and submitted but some errors are being returned.
					else if (responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
					{
						response = await ParsePartialSuccessAsync<CreateTaxFormResponse>(responseMessage, cancellationToken);
					}
				}

				return Result.Ok(response);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error creating tax form: {ErrorMessage}", ex.Message);
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
				requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(JSON_CONTENT_TYPE));

#if NET6_0_OR_GREATER
				using var client = _factory.CreateClient();
#elif NETSTANDARD2_0
				using var client = new HttpClient();
#endif
				var responseMessage = await client.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);

				if (responseMessage.IsSuccessStatusCode)
				{
					var response = new GetTaxFormResponse();
					if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK ||
						responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
					{
						// Determine what the data type is that is being returned.
						if (responseMessage.Content.Headers.ContentType.MediaType == JSON_CONTENT_TYPE)
						{
							response.ContentFormat = ContentType.JSON;
#if NET6_0_OR_GREATER
							response.ContentAsJson = await responseMessage.Content.ReadFromJsonAsync<TaxDataList>(cancellationToken).ConfigureAwait(false);
#elif NETSTANDARD2_0
							var json = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
							response.ContentAsJson = JsonSerializer.Deserialize<TaxDataList>(json);
#endif
						}
						else
						{
							response.ContentFormat = responseMessage.Content.Headers.ContentType.MediaType switch
							{
								"image/jpeg" => ContentType.JPEG,
								"image/png" => ContentType.PNG,
								"image/gif" => ContentType.GIF,
								"image/tiff" => ContentType.TIFF,
								"application/pdf" => ContentType.PDF,
								_ => throw new NotImplementedException()
							};
							response.ContentAsBase64 = await responseMessage.Content
#if NET6_0_OR_GREATER
								.ReadAsStringAsync(cancellationToken);
#elif NETSTANDARD2_0
								.ReadAsStringAsync();
#endif
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
				_logger.LogError(ex, "Error retrieving tax form: {ErrorMessage}", ex.Message);
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
				requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(JSON_CONTENT_TYPE));

#if NET6_0_OR_GREATER
				using var client = _factory.CreateClient();
#elif NETSTANDARD2_0
				using var client = new HttpClient();
#endif
				var responseMessage = await client.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);

				if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var response = new SearchForTaxFormsResponse();

#if NET6_0_OR_GREATER
					response.Content = await responseMessage.Content.ReadFromJsonAsync<TaxDataList>(cancellationToken);
#elif NETSTANDARD2_0
					var json = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
					response.Content = JsonSerializer.Deserialize<TaxDataList>(json);
#endif
					return Result.Ok(response);
				}
				else if (responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
				{
					var rsp = await ParsePartialSuccessAsync<SearchForTaxFormsResponse>(responseMessage, cancellationToken).ConfigureAwait(false);
					return Result.Ok(rsp);
				}
				else
				{
					return Result.Fail<SearchForTaxFormsResponse>("Error retrieving tax forms");
				}

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error retrieving tax forms: {ErrorMessage}", ex.Message);
				return Result.Fail<SearchForTaxFormsResponse>("Error retrieving tax forms");
			}
		}

		/// <inheritdoc />
		public async Task<Result<UpdateTaxFormResponse>> UpdateTaxFormAsync(UpdateTaxFormRequest request, CancellationToken cancellationToken = default)
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
					return Result.Fail<UpdateTaxFormResponse>(tokenResult.Errors);

				if (string.IsNullOrWhiteSpace(tokenResult.Value.AccessToken))
					return Result.Fail<UpdateTaxFormResponse>("No access token returned");

				// Create the request
#if NET6_0_OR_GREATER
				using var client = _factory.CreateClient();
#elif NETSTANDARD2_0
				using var client = new HttpClient();
#endif
				var requestMessage = new HttpRequestMessage(HttpMethod.Put, $"/tax-forms/{request.TaxFormId}");
				requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.Value.AccessToken);

				if (request.MediaType == ContentType.JSON)
#if NET6_0_OR_GREATER
					requestMessage.Content = JsonContent.Create<TaxDataList>(request.TaxData, MediaTypeHeaderValue.Parse(JSON_CONTENT_TYPE));
#elif NETSTANDARD2_0
					requestMessage.Content = new StringContent(JsonSerializer.Serialize(request.TaxData), Encoding.UTF8, JSON_CONTENT_TYPE);
#endif
				else
					requestMessage.Content = new StringContent(request.ImageAsBase64 ?? string.Empty, Encoding.UTF8, ContentTypeConverter.GetMimeType(request.MediaType));

				var responseMessage = await client.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);

				if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
				{
					return Result.Ok(new UpdateTaxFormResponse());
				}
				else if (responseMessage.StatusCode == System.Net.HttpStatusCode.PartialContent)
				{
					var rsp = await ParsePartialSuccessAsync<UpdateTaxFormResponse>(responseMessage, cancellationToken).ConfigureAwait(false);
					return Result.Ok(rsp);
				}
				else if (responseMessage.StatusCode == System.Net.HttpStatusCode.UnsupportedMediaType)
				{
					return Result.Fail<UpdateTaxFormResponse>("Unsupported media type");
				}
				else
				{
					return Result.Fail<UpdateTaxFormResponse>("Error updating tax form");
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error updating tax form: {ErrorMessage}", ex.Message);
				return Result.Fail<UpdateTaxFormResponse>("Error updating tax form");
			}
		}

		#region Private Methods

		internal async Task<T> ParsePartialSuccessAsync<T>(HttpResponseMessage responseMessage, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		private static StringBuilder AppendQueryString(StringBuilder builder, string key, string value)
		{
			if (builder[builder.Length - 1] != '?')
				builder.Append("&");
			else
				builder.Append("?");

			builder.Append($"{key}={value}");
			return builder;
		}

		#endregion
	}
}

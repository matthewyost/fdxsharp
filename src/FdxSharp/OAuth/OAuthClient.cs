using FluentResults;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
#if NET6_0_OR_GREATER
using System.Net.Http.Json;
#endif
namespace FdxSharp.OAuth
{
	/// <summary>
	/// Base implementation of an OAuth client that leverages the
	/// <see cref="OAuthClientCredentialsRequest"/> to retrieve an OAuth token.
	/// </summary>
	public sealed class OAuthClient : IOAuthClient
	{
		private readonly IHttpClientFactory _factory;
		private readonly IMemoryCache _cache;

		/// <summary>
		/// Creates a new instance of the <see cref="OAuthClient"/>
		/// </summary>
		/// <param name="factory">Used to create the <see cref="HttpClient"/> objects.</param>
		/// <param name="memCache">Memory Cache to cache the token to prevent calling the OAuth endpoint more than necessary</param>
		/// <exception cref="ArgumentNullException"></exception>
		public OAuthClient(IHttpClientFactory factory, IMemoryCache memCache)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
			_cache = memCache ?? throw new ArgumentNullException(nameof(memCache));
		}

		/// <inheritdoc />
		public async Task<Result<OAuthTokenResponse>> GetTokenAsync(OAuthClientCredentialsRequest request, CancellationToken cancellationToken = default)
		{
			try
			{
				// Check the cache for the token
				if (_cache.TryGetValue<OAuthTokenResponse>(request.ClientId, out var cachedToken))
				{
					return Result.Ok(cachedToken);
				}

				using var client = _factory.CreateClient();

				var requestMessage = new HttpRequestMessage(HttpMethod.Post, request.TokenUrl)
				{
					Content = new FormUrlEncodedContent(new[]
					{
						new KeyValuePair<string?, string?>("grant_type", "client_credentials"),
						new KeyValuePair<string?, string?>("client_id", request.ClientId),
						new KeyValuePair<string?, string?>("client_secret", request.ClientSecret),
						new KeyValuePair<string?, string?>("scope", request.Scope)
					})
				};

				requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

				var response = await client.SendAsync(requestMessage, cancellationToken);

				if (!response.IsSuccessStatusCode)
				{
					return Result.Fail<OAuthTokenResponse>("Failed to retrieve OAuth token");
				}

				var responseContent = await response.Content.ReadAsStringAsync();
				var oauthResponse = System.Text.Json.JsonSerializer.Deserialize<OAuthTokenResponse>(responseContent);

				_cache.Set(request.ClientId, oauthResponse, TimeSpan.FromSeconds(oauthResponse.ExpiresIn ?? 0));

				return Result.Ok(oauthResponse);
			}
			catch (Exception ex)
			{
				return Result.Fail<OAuthTokenResponse>(ex.Message);
			}
		}
	}
}

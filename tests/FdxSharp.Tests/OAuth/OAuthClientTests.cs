using AutoFixture;
using FdxSharp.OAuth;
using FdxSharp.Tests.Utilities;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FdxSharp.Tests.OAuth
{
	public class OAuthClientTests
	{
		private readonly Fixture _fixture = new();
		private readonly TestHttpClientFactory _factory = new();
		private OAuthClient _client;


		[Fact]
		public async Task GetTokenAsync_WhenCalled_ReturnsToken()
		{
			// Arrange
			MemoryCache _cache = new(new MemoryCacheOptions());
			_client = new OAuthClient(_factory, _cache);
			Func<HttpRequestMessage, HttpResponseMessage> func = (request) =>
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("{\"access_token\":\"token\",\"token_type\":\"bearer\",\"expires_in\":3600}")
				};
			};
			_factory.Func = func;

			// Act
			var result = await _client.GetTokenAsync(_fixture.Create<OAuthClientCredentialsRequest>());

			// Assert
			result.IsSuccess.Should().BeTrue();
		}

		[Fact]
		public async Task GetTokenAsync_WhenCalled_CachesToken()
		{
			// Arrange
			var request = _fixture.Create<OAuthClientCredentialsRequest>();
			var cacheValue = _fixture.Create<OAuthTokenResponse>();

			MemoryCache _cache = new(new MemoryCacheOptions());
			_cache.Set(request.ClientId, cacheValue);
			_client = new OAuthClient(_factory, _cache);

			Func<HttpRequestMessage, HttpResponseMessage> func = (request) =>
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("{\"access_token\":\"token\",\"token_type\":\"bearer\",\"expires_in\":3600}")
				};
			};
			_factory.Func = func;

			// Act
			var result = await _client.GetTokenAsync(request);

			// Assert
			using var scope = new AssertionScope();
			result.IsSuccess.Should().BeTrue();
			result.ValueOrDefault.Should().Be(cacheValue);
		}

		[Fact]
		public async Task GetTokenAsync_WhenCalled_ReturnsError()
		{
			// Arrange
			var request = _fixture.Create<OAuthClientCredentialsRequest>();
			var cacheValue = _fixture.Create<string>();

			MemoryCache _cache = new(new MemoryCacheOptions());
			_cache.Set<string>(request.ClientId, cacheValue);
			_client = new OAuthClient(_factory, _cache);

			Func<HttpRequestMessage, HttpResponseMessage> func = (request) =>
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
			};
			_factory.Func = func;

			// Act
			var result = await _client.GetTokenAsync(request);

			// Assert
			result.IsFailed.Should().BeTrue();
		}
	}
}

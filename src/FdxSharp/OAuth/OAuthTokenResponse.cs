using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.OAuth
{
	/// <summary>
	/// Response for an OAuth token request
	/// </summary>
	public class OAuthTokenResponse
	{
		/// <summary>
		/// Access token
		/// </summary>
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; set; }

		/// <summary>
		/// Token type
		/// </summary>
		[JsonPropertyName("token_type")]
		public string? TokenType { get; set; }

		/// <summary>
		/// Expires in
		/// </summary>
		[JsonPropertyName("expires_in")]
		public int? ExpiresIn { get; set; }

		/// <summary>
		/// Refresh token
		/// </summary>
		[JsonPropertyName("refresh_token")]
		public string? RefreshToken { get; set; }

		/// <summary>
		/// Scope
		/// </summary>
		[JsonPropertyName("scope")]
		public string? Scope { get; set; }
	}
}

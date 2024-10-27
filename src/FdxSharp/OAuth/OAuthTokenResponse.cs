using System.Text.Json.Serialization;

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

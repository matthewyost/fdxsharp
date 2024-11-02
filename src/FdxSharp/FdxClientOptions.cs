namespace FdxSharp
{
	/// <summary>
	/// Client Options for the <see cref="FdxClient"/>
	/// </summary>
	public class FdxClientOptions
	{
		/// <summary>
		/// URL that the client will make requests to.
		/// </summary>
		public string BaseUrl { get; set; }

		/// <summary>
		/// Client ID for OAuth2
		/// </summary>
		public string OAuthClientId { get; set; }

		/// <summary>
		/// Client Secret for OAuth2
		/// </summary>
		public string OAuthClientSecret { get; set; }

		/// <summary>
		/// URL to get an OAuth2 token
		/// </summary>
		public string OAuthTokenUrl { get; set; }

		/// <summary>
		/// OAuth2 Scope
		/// </summary>
		public string OAuthScope { get; set; }


	}
}

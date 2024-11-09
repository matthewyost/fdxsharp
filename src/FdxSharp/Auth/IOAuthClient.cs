namespace FdxSharp.Auth
{
	/// <summary>
	/// Interface for working with OAuth 2.0.  Allows for custom implementations of OAuth clients
	/// in the event that the default OAuth client does not meet the needs of the application.
	/// </summary>
	public interface IOAuthClient : IAuthClient<CredentialsRequest, OAuthTokenResponse>
	{
	}

}

using FluentResults;

namespace FdxSharp.OAuth
{
	/// <summary>
	/// Interface for working with OAuth 2.0.  Allows for custom implementations of OAuth clients
	/// in the event that the default OAuth client does not meet the needs of the application.
	/// </summary>
	public interface IOAuthClient : IOAuthClient<OAuthClientCredentialsRequest> { }

	/// <summary>
	/// Interface for working with OAuth 2.0.  Allows for custom implementations of OAuth clients
	/// in the event that the default OAuth client does not meet the needs of the application.
	/// </summary>
	public interface IOAuthClient<T>
	{
		/// <summary>
		/// Retrieve the OAuth token using the provided request
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<OAuthTokenResponse>> GetTokenAsync(T request, CancellationToken cancellationToken = default);
	}
}

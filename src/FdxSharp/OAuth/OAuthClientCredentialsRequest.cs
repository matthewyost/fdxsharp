#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.OAuth
{
	/// <summary>
	/// Request for an OAuth token using client credentials
	/// </summary>
	public class OAuthClientCredentialsRequest
	{
		/// <summary>
		/// URL to retrieve token from
		/// </summary>
		public string TokenUrl { get; set; }

		/// <summary>
		/// Client Id
		/// </summary>
		public string? ClientId { get; set; }

		/// <summary>
		/// Client Secret
		/// </summary>
		public string? ClientSecret { get; set; }

		/// <summary>
		/// Scope
		/// </summary>
		public string? Scope { get; set; }
	}
}

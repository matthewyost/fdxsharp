#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Settings
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
		/// Options related to OAuth 2.0
		/// </summary>
		public OAuthOptions OAuth { get; set; }


	}
}

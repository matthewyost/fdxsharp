using System;
using System.Collections.Generic;
using System.Text;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Settings
{
	/// <summary>
	/// Options class for OAuth 2.0
	/// </summary>
	public class OAuthOptions
	{
		/// <summary>
		/// Client ID for OAuth2
		/// </summary>
		public string ClientId { get; set; }

		/// <summary>
		/// Client Secret for OAuth2
		/// </summary>
		public string ClientSecret { get; set; }

		/// <summary>
		/// URL to get an OAuth2 token
		/// </summary>
		public string TokenUrl { get; set; }

		/// <summary>
		/// OAuth2 Scope
		/// </summary>
		public string Scope { get; set; }
	}
}

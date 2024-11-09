#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Auth
{
	/// <summary>
	/// Request for an OAuth token using client credentials
	/// </summary>
	public class CredentialsRequest
	{
		private const string CLIENT_ID = "ClientId";
		private const string CLIENT_SECRET = "ClientSecret";
		private const string SCOPE = "Scope";

		/// <summary>
		/// URL to retrieve token from
		/// </summary>
		public string? AuthenticationUrl { get; set; }

		/// <summary>
		/// Authentication Fields
		/// </summary>
		public Dictionary<string, string> AuthenticationFields { get; set; } = [];

		/// <summary>
		/// Client Id
		/// </summary>
		[JsonIgnore]
		public string ClientId
		{
			get
			{
				return (AuthenticationFields.ContainsKey(CLIENT_ID)) ? AuthenticationFields[CLIENT_ID] : "";
			}
			set
			{
				if (AuthenticationFields.ContainsKey(CLIENT_ID))
				{
					AuthenticationFields[CLIENT_ID] = value;
				}
				else
				{
					AuthenticationFields.Add(CLIENT_ID, value);
				}

			}
		}

		/// <summary>
		/// Client Secret
		/// </summary>
		[JsonIgnore]
		public string ClientSecret
		{
			get
			{
				return (AuthenticationFields.ContainsKey(CLIENT_SECRET)) ? AuthenticationFields[CLIENT_SECRET] : "";
			}
			set
			{
				if (AuthenticationFields.ContainsKey(CLIENT_SECRET))
				{
					AuthenticationFields[CLIENT_SECRET] = value;
				}
				else
				{
					AuthenticationFields.Add(CLIENT_SECRET, value);
				}
			}
		}

		/// <summary>
		/// Scope
		/// </summary>
		[JsonIgnore]
		public string Scope
		{
			get
			{
				return (AuthenticationFields.ContainsKey(SCOPE)) ? AuthenticationFields[SCOPE] : "";
			}
			set
			{
				if (AuthenticationFields.ContainsKey(SCOPE))
				{
					AuthenticationFields[SCOPE] = value;
				}
				else
				{
					AuthenticationFields.Add(SCOPE, value);
				}
			}
		}
	}
}

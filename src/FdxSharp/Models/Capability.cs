using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Capability entity, The response object for the API /capability request
	/// </summary>
	public class Capability
	{
		/// <summary>
		/// The FDX schema versions supported by one or more operations
		/// </summary>
		[JsonPropertyName("fdxVersions")]
		public string[]? FdxVersions { get; set; }

		/// <summary>
		/// The number of concurrent connections allowed for this client
		/// </summary>
		[JsonPropertyName("allowedConnections")]
		public int AllowedConnections { get; set; }

		/// <summary>
		/// The current number of active connections for this client
		/// </summary>
		[JsonPropertyName("activeConnections")]
		public int ActiveConnections { get; set; }

		/// <summary>
		/// Defaults to JSON
		/// </summary>
		[JsonPropertyName("messageFormat")]
		public string? MessageFormat { get; set; }

		/// <summary>
		/// The FDX API endpoints supported
		/// </summary>
		[JsonPropertyName("operations")]
		public Operation[]? Operations { get; set; }

		/// <summary>
		/// The URL to retrieve the JWKS public keys from the data provider, needed to enable payload level encryption above the TLS layer
		/// </summary>
		[JsonPropertyName("jwksUrl")]
		public HateoasLink? JwksUrl { get; set; }
	}
}

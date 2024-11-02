using FdxSharp.Enums;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Operation entity, Definition of a supported API for the /capability response object
	/// </summary>
	public class Operation
	{
		/// <summary>
		/// Operation ID (e.g. name) of this API
		/// </summary>
		[JsonPropertyName("id")]
		public OperationIdType? Id { get; set; }

		/// <summary>
		/// Whether and how this API is currently supported
		/// </summary>
		[JsonPropertyName("availability")]
		public Availability? Availability { get; set; }

		/// <summary>
		/// Additional FDX API endpoints supported at this API, e.g. Transactions within Accounts, or TxImages within Transactions
		/// </summary>
		[JsonPropertyName("alsoSupported")]
		public OperationIdType[]? AlsoSupported { get; set; }

		/// <summary>
		/// Data provider's implementation version number for this operation, which is unrelated to the FDX API version
		/// </summary>
		[JsonPropertyName("version")]
		public string? Version { get; set; }

		/// <summary>
		/// FDX schema versions supported at this endpoint
		/// </summary>
		[JsonPropertyName("fdxVersions")]
		public string[]? FdxVersions { get; set; }

		/// <summary>
		/// Cut off time for same-day execution of activity request submitted to this API. Alternatively, the as-of time when EOD account balances are typically set
		/// </summary>
		[JsonPropertyName("cutOffTime")]
		public DateTime? CutOffTime { get; set; }

		/// <summary>
		/// General HATEOAS link for this API, specifying supported action (GET, POST, etc) and contentTypes (application/json, image/png, etc), but without any path parameter values
		/// </summary>
		[JsonPropertyName("link")]
		public HateoasLink? Link { get; set; }
	}
}

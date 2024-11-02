using FdxSharp.Enums;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Requests
{
	/// <summary>
	/// Get the full lists of tax document data and tax form images available for a specific year for the current authorized customer
	/// </summary>
	public class SearchForTaxFormsRequest
	{
		/// <summary>
		/// One or more tax years in which to search for tax forms. Comma separated. Deprecated in favor of single taxYear parameter, will be removed in FDX v6.0
		/// </summary>
		[JsonPropertyName("taxYears")]
		public int[]? TaxYears { get; set; }

		/// <summary>
		/// Account Identifier for use in searching or authorization. Optional
		/// </summary>
		[JsonPropertyName("accountId")]
		public string? AccountId { get; set; }

		/// <summary>
		/// Tax year in which to search for tax forms. Optional
		/// </summary>
		[JsonPropertyName("taxYear")]
		public int? TaxYear { get; set; }

		/// <summary>
		/// One or more tax form type enums for the specific documents being requested. Comma separated
		/// </summary>
		[JsonPropertyName("taxForms")]
		public TaxFormType[]? TaxForms { get; set; }

		/// <summary>
		/// Opaque cursor used by the provider to send the next set of records
		/// </summary>
		[JsonPropertyName("offset")]
		public string? Offset { get; set; }

		/// <summary>
		/// Number of elements that the consumer wishes to receive. Providers should implement reasonable default and maximum values
		/// </summary>
		[JsonPropertyName("limit")]
		public int? Limit { get; set; }

		/// <summary>
		/// One or more content-types to request from the search. Use 'application/json' to request data, image content types to request images. Comma separated
		/// </summary>
		[JsonPropertyName("contentTypes")]
		public ContentType[]? ContentTypes { get; set; }

		/// <summary>
		/// Flag to indicate if you want a lightweight array of metadata (AccountDescriptor or Tax or Operations) or full item details (Account or a Tax subclass or Availability details). If set to 'lightweight', should only return the fields associated with the metadata entity. This field is not required, defaults to lightweight
		/// </summary>
		[JsonPropertyName("resultType")]
		public ResultType? ResultType { get; set; }
	}
}

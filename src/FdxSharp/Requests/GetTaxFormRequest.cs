using System.Text.Json.Serialization;

namespace FdxSharp.Requests;

/// <summary>
/// Retrieve tax form
/// </summary>
/// <remarks>
/// Get the form image or TaxDataList as json for a single tax document for the customer. 
/// Use [HTTP Accept request-header](https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html) to 
/// specify desired content types. See ContentTypes definition for typical values
/// </remarks>
public class GetTaxFormRequest
{
	/// <summary>
	/// The unique ID for this tax form
	/// </summary>
	[JsonPropertyName("taxFormId")]
	public required string TaxFormId { get; set; }

	/// <summary>
	/// Account Identifier for use in searching or authorization. Optional
	/// </summary>
	[JsonPropertyName("accountId")]
	public string? AccountId { get; set; }

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
}

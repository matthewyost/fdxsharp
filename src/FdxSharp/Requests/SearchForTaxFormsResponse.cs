using FdxSharp.Models;

namespace FdxSharp.Requests;

/// <summary>
/// (200) Array of metadata for all the tax document data and tax form images available for the customer matching search criteria.
/// (206) Partial Content success searching for customer Tax Data forms, some errors are being returned
/// </summary>
public class SearchForTaxFormsResponse
{
	/// <summary>
	/// Contains the metadata for the paginated array of tax data
	/// </summary>
	public TaxDataList? Content { get; set; }

	/// <summary>
	/// Contains any errors that occurred while processing the request
	/// </summary>
	public Error[]? Errors { get; set; }
}

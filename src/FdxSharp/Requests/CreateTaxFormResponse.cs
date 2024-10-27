using FdxSharp.Models;

namespace FdxSharp.Requests;

/// <summary>
/// Create tax form
/// </summary>
/// <remarks>
/// Submit the data for a specific tax document
/// </remarks>
public class CreateTaxFormResponse
{
	/// <summary>
	/// The tax data that was created
	/// </summary>
	public TaxDataList? Content { get; set; }

	/// <summary>
	/// Contains the errors that occurred while processing the request
	/// </summary>
	public Error[]? Errors { get; set; }

}

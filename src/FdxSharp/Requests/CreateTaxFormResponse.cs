using FdxSharp.Models;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Requests
{
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
}

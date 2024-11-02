using FdxSharp.Enums;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Requests
{
	/// <summary>
	/// Request to update a tax form with new data
	/// </summary>
	public class UpdateTaxFormRequest
	{
		/// <summary>
		/// The ID of the tax form to update
		/// </summary>
		public string? TaxFormId { get; set; }

		/// <summary>
		/// Content type of the request
		/// </summary>
		public ContentType MediaType { get; set; }

		/// <summary>
		/// Tax data to update
		/// </summary>
		public TaxDataList? TaxData { get; set; }

		/// <summary>
		/// Base64 encoded image of the tax form
		/// </summary>
		public string? ImageAsBase64 { get; set; }
	}
}

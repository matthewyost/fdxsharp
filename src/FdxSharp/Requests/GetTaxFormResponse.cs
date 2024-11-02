using FdxSharp.Enums;
using FdxSharp.Models;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Requests
{
	/// <summary>
	/// (200) The document image or TaxDataList as json for a single tax document for the customer. 
	/// A single document can include multiple IRS tax forms and/or other reporting statements 
	/// as delivered by providers.
	/// 
	/// (206) Partial Content success retrieving a customer tax document, some errors are being returned
	/// </summary>
	public class GetTaxFormResponse
	{
		/// <summary>
		/// Format of the content
		/// </summary>
		public ContentType ContentFormat { get; set; }

		/// <summary>
		/// JSON representation of the tax form data
		/// </summary>
		public TaxDataList? ContentAsJson { get; set; }


		/// <summary>
		/// Base64 encoded image of the tax document
		/// </summary>
		public string? ContentAsBase64 { get; set; }

		/// <summary>
		/// Any errors that occurred during the request
		/// </summary>
		public Error[]? Errors { get; set; }
	}
}
using FdxSharp.Models;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Requests
{
	/// <summary>
	/// Response for updating a tax form
	/// </summary>
	public class UpdateTaxFormResponse
	{
		/// <summary>
		/// HTTP response code
		/// </summary>
		public int ResponseCode { get; set; }

		/// <summary>
		/// Partial content success updating customer tax document,
		/// some errors are being returned
		/// </summary>
		public TaxDataList? PartialContent { get; set; }

		/// <summary>
		/// Errors returned from the request
		/// </summary>
		public Error? Error { get; set; }
	}
}

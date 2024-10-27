using FdxSharp.Requests;
using FluentResults;
using Microsoft.Extensions.Options;

namespace FdxSharp
{
	/// <summary>
	/// Interface for working with an FDX server
	/// </summary>
	public interface IFdxClient
	{
		/// <summary>
		/// Allows the setting of options specifically for an FdxClient
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		IFdxClient WithOptions(IOptions<FdxClientOptions> options);

		/// <summary>
		/// Submit the data for a specific tax document
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<CreateTaxFormResponse>> CreateTaxFormAsync(CreateTaxFormRequest request, CancellationToken cancellationToken = default);

		/// <summary>
		/// Get the full lists of tax document data and tax form images available for a specific year for the current authorized customer
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<SearchForTaxFormsResponse>> GetTaxFormsAsync(SearchForTaxFormsRequest request, CancellationToken cancellationToken = default);

		/// <summary>
		/// Get the form image or TaxDataList as json for a single tax document for the customer. Use [HTTP Accept request-header](https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html) 
		/// to specify desired content types. See ContentTypes definition for typical values
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<GetTaxFormResponse>> GetTaxFormAsync(GetTaxFormRequest request, CancellationToken cancellationToken = default);

		/// <summary>
		/// Update tax document. Allows you to upload and replace binaries or json document
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<Result<UpdateTaxFormResponse>> UpdateTaxFormAsync(UpdateTaxFormRequest request, CancellationToken cancellationToken = default);

	}
}

using FdxSharp.Enums;
using FdxSharp.Forms;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Tax, Base entity for all IRS Tax forms
	/// </summary>
	public abstract class Tax
	{
		/// <summary>
		/// Year for which taxes are being paid
		/// </summary>
		[JsonPropertyName("taxYear")]
		public int TaxYear { get; set; }

		/// <summary>
		/// True to indicate this is a corrected tax form
		/// </summary>
		[JsonPropertyName("corrected")]
		public bool Corrected { get; set; }

		/// <summary>
		/// Long-term persistent identity of the source account. Not the account number
		/// </summary>
		[JsonPropertyName("accountId")]
		public string? AccountId { get; set; }

		/// <summary>
		/// Long-term persistent id for the tax form instance
		/// </summary>
		[JsonPropertyName("taxFormId")]
		public string? TaxFormId { get; set; }

		/// <summary>
		/// Date of production or delivery of the tax form
		/// </summary>
		[JsonPropertyName("taxFormDate")]
		public string TaxFormDate { get; set; }

		/// <summary>
		/// Description of the tax document
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Additional explanation text or content for taxpayer or preparer or IRS about the tax document
		/// </summary>
		[JsonPropertyName("additionalInformation")]
		public string? AdditionalInformation { get; set; }

		/// <summary>
		/// Enumerated name of the tax form entity e.g. "TaxW2"
		/// </summary>
		[JsonPropertyName("taxFormType")]
		public TaxFormType TaxFormType { get; set; }

		/// <summary>
		/// Additional tax form attributes when defined fields are not available
		/// </summary>
		[JsonPropertyName("attributes")]
		public TaxFormAttribute[]? Attributes { get; set; }

		/// <summary>
		/// Present if an error was encountered while retrieving this form
		/// </summary>
		[JsonPropertyName("error")]
		public Error? Error { get; set; }

		/// <summary>
		/// Links to retrieve this form as data or image, or to invoke other APIs
		/// </summary>
		[JsonPropertyName("links")]
		public List<string>? Links { get; set; }
	}
}

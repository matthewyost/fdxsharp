using FdxSharp.Enums;
using FdxSharp.Forms;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Tax, Base entity for all IRS Tax forms
	/// </summary>
    public abstract class Tax
	{
		/// <summary>
		/// Get or set the tax year
		/// </summary>
		[JsonPropertyName("taxYear")]
		public int TaxYear { get; set; }

		/// <summary>
		/// Get or set the corrected flag
		/// </summary>
		[JsonPropertyName("corrected")]
		public bool Corrected { get; set; }

		/// <summary>
		/// Get or set the account id
		/// </summary>
		[JsonPropertyName("accountId")]
		public string? AccountId { get; set; }

		/// <summary>
		/// Get or set the tax form id
		/// </summary>
		[JsonPropertyName("taxFormId")]
		public string? TaxFormId { get; set; }

		/// <summary>
		/// Get or set the tax form date
		/// </summary>
		[JsonPropertyName("taxFormDate")]
		public DateOnly TaxFormDate { get; set; }

		/// <summary>
		/// Get or set the description
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Get or set the additional information
		/// </summary>
		[JsonPropertyName("additionalInformation")]
		public string? AdditionalInformation { get; set; }

		/// <summary>
		/// Get or set the tax form type
		/// </summary>
		[JsonPropertyName("taxFormType")]
		public TaxFormType TaxFormType { get; set; }

		/// <summary>
		/// Get or set the tax form attributes
		/// </summary>
		[JsonPropertyName("attributes")]
		public TaxFormAttribute[]? Attributes { get; set; }

		/// <summary>
		/// Get or set the error
		/// </summary>
		[JsonPropertyName("error")]
		public Error Error { get; set; }

		/// <summary>
		/// Get or set the links
		/// </summary>
		[JsonPropertyName("links")]
		public List<string> Links { get; set; }
	}
}

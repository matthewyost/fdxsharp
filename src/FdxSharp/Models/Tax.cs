using FdxSharp.Enums;
using FdxSharp.Forms;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
    public abstract class Tax
	{
		[JsonPropertyName("taxYear")]
		public int TaxYear { get; set; }

		[JsonPropertyName("corrected")]
		public bool Corrected { get; set; }

		[JsonPropertyName("accountId")]
		public string? AccountId { get; set; }

		[JsonPropertyName("taxFormId")]
		public string? TaxFormId { get; set; }

		[JsonPropertyName("taxFormDate")]
		public DateOnly TaxFormDate { get; set; }

		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("additionalInformation")]
		public string? AdditionalInformation { get; set; }

		[JsonPropertyName("taxFormType")]
		public TaxFormType TaxFormType { get; set; }

		[JsonPropertyName("attributes")]
		public TaxFormAttribute[]? Attributes { get; set; }

		[JsonPropertyName("error")]
		public Error Error { get; set; }

		[JsonPropertyName("links")]
		public List<string> Links { get; set; }
	}
}

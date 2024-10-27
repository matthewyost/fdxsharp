using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Offer of Health Insurance Coverage, Health insurance coverage offer for part II of IRS Form 1095-C
	/// </summary>
	public class OfferOfHealthInsuranceCoverage
	{
		/// <summary>
		/// Offer of Coverage (enter required code).
		/// </summary>
		[JsonPropertyName("coverageCode")]
		public string CoverageCode { get; set; }

		/// <summary>
		/// Employee required contribution.
		/// </summary>
		[JsonPropertyName("requiredContribution")]
		public double RequiredContribution { get; set; }

		/// <summary>
		/// Section 4980H Safe Harbor and Other Relief (enter code).
		/// </summary>
		[JsonPropertyName("section4980HCode")]
		public string Section4980HCode { get; set; }

		/// <summary>
		/// Box 17, ZIP Code.
		/// </summary>
		[JsonPropertyName("postalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// Month of coverage.
		/// </summary>
		[JsonPropertyName("month")]
		public CoverageMonthType Month { get; set; }
	}
}

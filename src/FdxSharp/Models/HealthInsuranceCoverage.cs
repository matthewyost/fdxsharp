using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Health Insurance Coverage, Used on Form 1095-A Part III
	/// </summary>
	public class HealthInsuranceCoverage
	{
		/// <summary>
		/// Monthly enrollment premiums.
		/// </summary>
		[JsonPropertyName("enrollmentPremium")]
		public double EnrollmentPremium { get; set; }

		/// <summary>
		/// Monthly second lowest cost silver plan (SLCSP) premium.
		/// </summary>
		[JsonPropertyName("slcspPremium")]
		public double SlcspPremium { get; set; }

		/// <summary>
		/// Monthly advance payment of premium tax credit.
		/// </summary>
		[JsonPropertyName("advancePremiumTaxCreditPayment")]
		public double AdvancePremiumTaxCreditPayment { get; set; }

		/// <summary>
		/// Month of coverage.
		/// </summary>
		[JsonPropertyName("month")]
		public CoverageMonthType Month { get; set; }
	}
}

using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 5498-QA, ABLE Account Contribution Information
	/// </summary>
	public class Tax5498Qa : Tax
	{
		/// <summary>
		/// ISSUER'S name, street address, city or town, state or province, country, and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddress? IssuerNameAddress { get; set; }

		/// <summary>
		/// ISSUER'S TIN
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

		/// <summary>
		/// BENEFICIARY'S TIN
		/// </summary>
		[JsonPropertyName("beneficiaryTin")]
		public string? BeneficiaryTin { get; set; }

		/// <summary>
		/// BENEFICIARY'S name and address
		/// </summary>
		[JsonPropertyName("beneficiaryNameAddress")]
		public NameAddress? BeneficiaryNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, ABLE contributions
		/// </summary>
		[JsonPropertyName("ableContributions")]
		public double AbleContributions { get; set; }

		/// <summary>
		/// Box 2, ABLE to ABLE Rollovers
		/// </summary>
		[JsonPropertyName("rollovers")]
		public double Rollovers { get; set; }

		/// <summary>
		/// Box 3, Cumulative contributions
		/// </summary>
		[JsonPropertyName("cumulativeContributions")]
		public double CumulativeContributions { get; set; }

		/// <summary>
		/// Box 4, Fair market value
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 5, Check if account opened in current tax year
		/// </summary>
		[JsonPropertyName("openedInTaxYear")]
		public bool OpenedInTaxYear { get; set; }

		/// <summary>
		/// Box 6, Basis of eligibility
		/// </summary>
		[JsonPropertyName("basisOfDisabilityCode")]
		public string? BasisOfDisabilityCode { get; set; }

		/// <summary>
		/// Box 7, Code
		/// </summary>
		[JsonPropertyName("typeOfDisabilityCode")]
		public string? TypeOfDisabilityCode { get; set; }
	}
}

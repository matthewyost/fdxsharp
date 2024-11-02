using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 5498-ESA, Coverdell ESA Contribution Information
	/// </summary>
	public class Tax5498Esa : Tax
	{
		/// <summary>
		/// Issuer's name, address, and phone
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone? IssuerNameAddress { get; set; }

		/// <summary>
		/// TRUSTEE'S/ISSUER'S TIN
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

		/// <summary>
		/// BENEFICIARY'S TIN
		/// </summary>
		[JsonPropertyName("beneficiaryTin")]
		public string? BeneficiaryTin { get; set; }

		/// <summary>
		/// Beneficiary's name and address
		/// </summary>
		[JsonPropertyName("beneficiaryNameAddress")]
		public NameAddress? BeneficiaryNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Coverdell ESA contributions
		/// </summary>
		[JsonPropertyName("coverdellEsaContributions")]
		public double CoverdellEsaContributions { get; set; }

		/// <summary>
		/// Box 2, Rollover contributions
		/// </summary>
		[JsonPropertyName("rolloverContributions")]
		public double RolloverContributions { get; set; }
	}
}

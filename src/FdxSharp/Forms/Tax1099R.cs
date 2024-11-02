using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-R, Distributions from Pensions, Annuities, Retirement or Profit-Sharing Plans, IRAs, Insurance Contracts, etc.
	/// </summary>
	public class Tax1099R : Tax
	{
		/// <summary>
		/// Payer's name, address, and phone
		/// </summary>
		[JsonPropertyName("payerNameAddress")]
		public NameAddressPhone? PayerNameAddress { get; set; }

		/// <summary>
		/// PAYER'S TIN
		/// </summary>
		[JsonPropertyName("payerTin")]
		public string? PayerTin { get; set; }

		/// <summary>
		/// RECIPIENT'S TIN
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string? RecipientTin { get; set; }

		/// <summary>
		/// Recipient's name and address
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Box 10, Amount allocable to IRR within 5 years
		/// </summary>
		[JsonPropertyName("allocableToIRR")]
		public double AllocableToIRR { get; set; }

		/// <summary>
		/// Box 11, First year of designated Roth
		/// </summary>
		[JsonPropertyName("firstYearOfRoth")]
		public int? FirstYearOfRoth { get; set; }

		/// <summary>
		/// FATCA filing requirement
		/// </summary>
		[JsonPropertyName("foreignAccountTaxCompliance")]
		public bool ForeignAccountTaxCompliance { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("recipientAccountNumber")]
		public string? RecipientAccountNumber { get; set; }

		/// <summary>
		/// Date of payment
		/// </summary>
		[JsonPropertyName("dateOfPayment")]
		public DateTime? DateOfPayment { get; set; }

		/// <summary>
		/// Box 1, Gross distribution
		/// </summary>
		[JsonPropertyName("grossDistribution")]
		public double GrossDistribution { get; set; }

		/// <summary>
		/// Box 2a, Taxable amount
		/// </summary>
		[JsonPropertyName("taxableAmount")]
		public double TaxableAmount { get; set; }

		/// <summary>
		/// Box 2b, Taxable amount not determined
		/// </summary>
		[JsonPropertyName("taxableAmountNotDetermined")]
		public bool TaxableAmountNotDetermined { get; set; }

		/// <summary>
		/// Box 2c, Total distribution
		/// </summary>
		[JsonPropertyName("totalDistribution")]
		public bool TotalDistribution { get; set; }

		/// <summary>
		/// Box 3, Capital gain
		/// </summary>
		[JsonPropertyName("capitalGain")]
		public double CapitalGain { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Employee contributions
		/// </summary>
		[JsonPropertyName("employeeContributions")]
		public double EmployeeContributions { get; set; }

		/// <summary>
		/// Box 6, Net unrealized appreciation
		/// </summary>
		[JsonPropertyName("netUnrealizedAppreciation")]
		public double NetUnrealizedAppreciation { get; set; }

		/// <summary>
		/// Box 7, Distribution codes
		/// </summary>
		[JsonPropertyName("distributionCodes")]
		public string[]? DistributionCodes { get; set; }

		/// <summary>
		/// Box 7b, IRA/SEP/SIMPLE
		/// </summary>
		[JsonPropertyName("iraSepSimple")]
		public bool IraSepSimple { get; set; }

		/// <summary>
		/// Box 8, Other
		/// </summary>
		[JsonPropertyName("otherAmount")]
		public double OtherAmount { get; set; }

		/// <summary>
		/// Box 8, Other percent
		/// </summary>
		[JsonPropertyName("otherPercent")]
		public double OtherPercent { get; set; }

		/// <summary>
		/// Box 9a, Your percent of total distribution
		/// </summary>
		[JsonPropertyName("yourPercentOfTotal")]
		public double YourPercentOfTotal { get; set; }

		/// <summary>
		/// Box 9b, Total employee contributions
		/// </summary>
		[JsonPropertyName("totalEmployeeContributions")]
		public double TotalEmployeeContributions { get; set; }

		/// <summary>
		/// Boxes 12-14, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Boxes 15-17, Local tax withholding
		/// </summary>
		[JsonPropertyName("localTaxWithholding")]
		public LocalTaxWithholding[]? LocalTaxWithholding { get; set; }
	}
}

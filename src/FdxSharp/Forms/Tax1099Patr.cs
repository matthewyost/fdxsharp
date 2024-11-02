using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-PATR, Taxable Distributions Received From Cooperatives
	/// </summary>
	public class Tax1099Patr : Tax
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
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Patronage dividends
		/// </summary>
		[JsonPropertyName("patronageDividends")]
		public double PatronageDividends { get; set; }

		/// <summary>
		/// Box 2, Nonpatronage distributions
		/// </summary>
		[JsonPropertyName("nonpatronageDistributions")]
		public double NonpatronageDistributions { get; set; }

		/// <summary>
		/// Box 3, Per-unit retain allocations
		/// </summary>
		[JsonPropertyName("perUnitRetainAllocations")]
		public double PerUnitRetainAllocations { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Redemption of nonqualified notices and retain allocations
		/// </summary>
		[JsonPropertyName("redemption")]
		public double Redemption { get; set; }

		/// <summary>
		/// 2019 Box 6, Domestic production activities deduction (IRS removed 2020)
		/// </summary>
		[JsonPropertyName("dpaDeduction")]
		public double DpaDeduction { get; set; }

		/// <summary>
		/// Box 6, Section 199A(g) deduction
		/// </summary>
		[JsonPropertyName("section199Deduction")]
		public double Section199Deduction { get; set; }

		/// <summary>
		/// Box 7, Qualified payments
		/// </summary>
		[JsonPropertyName("qualifiedPayments")]
		public double QualifiedPayments { get; set; }

		/// <summary>
		/// Box 8, Section 199A(a) qualified items
		/// </summary>
		[JsonPropertyName("section199QualifiedItems")]
		public double Section199QualifiedItems { get; set; }

		/// <summary>
		/// Box 9, Section 199A(a) SSTB (Specified Service Trade or Business) items
		/// </summary>
		[JsonPropertyName("section199SstbItems")]
		public double Section199SstbItems { get; set; }

		/// <summary>
		/// Box 10, Investment credit
		/// </summary>
		[JsonPropertyName("investmentCredit")]
		public double InvestmentCredit { get; set; }

		/// <summary>
		/// Box 11, Work opportunity credit
		/// </summary>
		[JsonPropertyName("workOpportunityCredit")]
		public double WorkOpportunityCredit { get; set; }

		/// <summary>
		/// 2019 Box 10, Patron's AMT adjustment (IRS removed 2020)
		/// </summary>
		[JsonPropertyName("patronsAmtAdjustment")]
		public double PatronsAmtAdjustment { get; set; }

		/// <summary>
		/// Box 12, Other credits and deductions
		/// </summary>
		[JsonPropertyName("otherCreditsAndDeductions")]
		public double OtherCreditsAndDeductions { get; set; }

		/// <summary>
		/// Box 13, Specified Cooperative
		/// </summary>
		[JsonPropertyName("specifiedCoop")]
		public bool SpecifiedCoop { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

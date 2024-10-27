using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-DIV, Dividends and Distributions
	/// </summary>
	public class Tax1099Div : Tax
	{
		/// <summary>
		/// Payer's name, address, and phone
		/// </summary>
		[JsonPropertyName("payerNameAddress")]
		public NameAddressPhone? PayerNameAddress { get; set; }

		/// <summary>
		/// Payer's TIN
		/// </summary>
		[JsonPropertyName("payerTin")]
		public string? PayerTin { get; set; }

		/// <summary>
		/// Recipient's TIN
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string? RecipientTin { get; set; }

		/// <summary>
		/// Recipient's name and address
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// FATCA filing requirement
		/// </summary>
		[JsonPropertyName("foreignAccountTaxCompliance")]
		public bool ForeignAccountTaxCompliance { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1a, Total ordinary dividends
		/// </summary>
		[JsonPropertyName("ordinaryDividends")]
		public double OrdinaryDividends { get; set; }

		/// <summary>
		/// Box 1b, Qualified dividends
		/// </summary>
		[JsonPropertyName("qualifiedDividends")]
		public double QualifiedDividends { get; set; }

		/// <summary>
		/// Box 2a, Total capital gain distributions
		/// </summary>
		[JsonPropertyName("totalCapitalGain")]
		public double TotalCapitalGain { get; set; }

		/// <summary>
		/// Box 2b, Unrecaptured Section 1250 gain
		/// </summary>
		[JsonPropertyName("unrecaptured1250Gain")]
		public double Unrecaptured1250Gain { get; set; }

		/// <summary>
		/// Box 2c, Section 1202 gain
		/// </summary>
		[JsonPropertyName("section1202Gain")]
		public double Section1202Gain { get; set; }

		/// <summary>
		/// Box 2d, Collectibles (28%) gain
		/// </summary>
		[JsonPropertyName("collectiblesGain")]
		public double CollectiblesGain { get; set; }

		/// <summary>
		/// Box 2e, Section 897 ordinary dividends
		/// </summary>
		[JsonPropertyName("section897Dividends")]
		public double Section897Dividends { get; set; }

		/// <summary>
		/// Box 2f, Section 897 capital gain
		/// </summary>
		[JsonPropertyName("section897CapitalGain")]
		public double Section897CapitalGain { get; set; }

		/// <summary>
		/// Box 3, Nondividend distributions
		/// </summary>
		[JsonPropertyName("nonTaxableDistribution")]
		public double NonTaxableDistribution { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Section 199A dividends
		/// </summary>
		[JsonPropertyName("section199ADividends")]
		public double Section199ADividends { get; set; }

		/// <summary>
		/// Box 6, Investment expenses
		/// </summary>
		[JsonPropertyName("investmentExpenses")]
		public double InvestmentExpenses { get; set; }

		/// <summary>
		/// Box 7, Foreign tax paid
		/// </summary>
		[JsonPropertyName("foreignTaxPaid")]
		public double ForeignTaxPaid { get; set; }

		/// <summary>
		/// Box 8, Foreign country or U.S. possession
		/// </summary>
		[JsonPropertyName("foreignCountry")]
		public string? ForeignCountry { get; set; }

		/// <summary>
		/// Box 9, Cash liquidation distributions
		/// </summary>
		[JsonPropertyName("cashLiquidation")]
		public double CashLiquidation { get; set; }

		/// <summary>
		/// Box 10, Noncash liquidation distributions
		/// </summary>
		[JsonPropertyName("nonCashLiquidation")]
		public double NonCashLiquidation { get; set; }

		/// <summary>
		/// Box 11, Exempt-interest dividends
		/// </summary>
		[JsonPropertyName("taxExemptInterestDividend")]
		public double TaxExemptInterestDividend { get; set; }

		/// <summary>
		/// Box 12, Specified private activity bond interest dividends
		/// </summary>
		[JsonPropertyName("specifiedPabInterestDividend")]
		public double SpecifiedPabInterestDividend { get; set; }

		/// <summary>
		/// Boxes 13-15, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Foreign income information
		/// </summary>
		[JsonPropertyName("foreignIncomes")]
		public DescriptionAmount[]? ForeignIncomes { get; set; }

		/// <summary>
		/// Tax exempt income state information
		/// </summary>
		[JsonPropertyName("stateTaxExemptIncomes")]
		public DescriptionAmount[]? StateTaxExemptIncomes { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

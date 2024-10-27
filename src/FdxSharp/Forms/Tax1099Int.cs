using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-INT, Interest Income
	/// </summary>
	public class Tax1099Int : Tax
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
		/// Payer's RTN
		/// </summary>
		[JsonPropertyName("payerRtn")]
		public string? PayerRtn { get; set; }

		/// <summary>
		/// Box 1, Interest income
		/// </summary>
		[JsonPropertyName("interestIncome")]
		public double InterestIncome { get; set; }

		/// <summary>
		/// Box 2, Early withdrawal penalty
		/// </summary>
		[JsonPropertyName("earlyWithdrawalPenalty")]
		public double EarlyWithdrawalPenalty { get; set; }

		/// <summary>
		/// Box 3, Interest on U.S. Savings Bonds and Treasury obligations
		/// </summary>
		[JsonPropertyName("usBondInterest")]
		public double UsBondInterest { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Investment expenses
		/// </summary>
		[JsonPropertyName("investmentExpenses")]
		public double InvestmentExpenses { get; set; }

		/// <summary>
		/// Box 6, Foreign tax paid
		/// </summary>
		[JsonPropertyName("foreignTaxPaid")]
		public double ForeignTaxPaid { get; set; }

		/// <summary>
		/// Box 7, Foreign country or U.S. possession
		/// </summary>
		[JsonPropertyName("foreignCountry")]
		public string? ForeignCountry { get; set; }

		/// <summary>
		/// Box 8, Tax-exempt interest
		/// </summary>
		[JsonPropertyName("taxExemptInterest")]
		public double TaxExemptInterest { get; set; }

		/// <summary>
		/// Box 9, Specified private activity bond interest
		/// </summary>
		[JsonPropertyName("specifiedPabInterest")]
		public double SpecifiedPabInterest { get; set; }

		/// <summary>
		/// Box 10, Market discount
		/// </summary>
		[JsonPropertyName("marketDiscount")]
		public double MarketDiscount { get; set; }

		/// <summary>
		/// Box 11, Bond premium
		/// </summary>
		[JsonPropertyName("bondPremium")]
		public double BondPremium { get; set; }

		/// <summary>
		/// Box 12, Bond premium on Treasury obligations
		/// </summary>
		[JsonPropertyName("usBondPremium")]
		public double UsBondPremium { get; set; }

		/// <summary>
		/// Box 13, Bond premium on tax-exempt bond
		/// </summary>
		[JsonPropertyName("taxExemptBondPremium")]
		public double TaxExemptBondPremium { get; set; }

		/// <summary>
		/// Box 14, Tax-exempt bond CUSIP no.
		/// </summary>
		[JsonPropertyName("cusipNumber")]
		public string? CusipNumber { get; set; }

		/// <summary>
		/// Boxes 15-17, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Supplemental foreign income amount information (description is country)
		/// </summary>
		[JsonPropertyName("foreignIncomes")]
		public DescriptionAmount[]? ForeignIncomes { get; set; }

		/// <summary>
		/// Supplemental tax-exempt income by state (description is state)
		/// </summary>
		[JsonPropertyName("stateTaxExemptIncome")]
		public DescriptionAmount[]? StateTaxExemptIncome { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

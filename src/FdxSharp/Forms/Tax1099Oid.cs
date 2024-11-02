using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-OID, Original Issue Discount
	/// </summary>
	public class Tax1099Oid : Tax
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
		/// Box 1, Original issue discount
		/// </summary>
		[JsonPropertyName("originalIssueDiscount")]
		public double OriginalIssueDiscount { get; set; }

		/// <summary>
		/// Box 2, Other periodic interest
		/// </summary>
		[JsonPropertyName("otherPeriodicInterest")]
		public double OtherPeriodicInterest { get; set; }

		/// <summary>
		/// Box 3, Early withdrawal penalty
		/// </summary>
		[JsonPropertyName("earlyWithdrawalPenalty")]
		public double EarlyWithdrawalPenalty { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Market discount
		/// </summary>
		[JsonPropertyName("marketDiscount")]
		public double MarketDiscount { get; set; }

		/// <summary>
		/// Box 6, Acquisition premium
		/// </summary>
		[JsonPropertyName("acquisitionPremium")]
		public double AcquisitionPremium { get; set; }

		/// <summary>
		/// Box 7, Description
		/// </summary>
		[JsonPropertyName("oidDescription")]
		public string? OidDescription { get; set; }

		/// <summary>
		/// Box 8, Original issue discount on U.S. Treasury obligations
		/// </summary>
		[JsonPropertyName("discountOnTreasuryObligations")]
		public double DiscountOnTreasuryObligations { get; set; }

		/// <summary>
		/// Box 9, Investment expenses
		/// </summary>
		[JsonPropertyName("investmentExpenses")]
		public double InvestmentExpenses { get; set; }

		/// <summary>
		/// Box 10, Bond premium
		/// </summary>
		[JsonPropertyName("bondPremium")]
		public double BondPremium { get; set; }

		/// <summary>
		/// Box 11, Tax-exempt OID
		/// </summary>
		[JsonPropertyName("taxExemptOid")]
		public double TaxExemptOid { get; set; }

		/// <summary>
		/// Boxes 12-14, State tax withheld
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Supplemental: State name and tax-exempt OID by state
		/// </summary>
		[JsonPropertyName("stateExemptOid")]
		public DescriptionAmount[]? StateExemptOid { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

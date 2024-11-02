using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-MISC, Miscellaneous Income
	/// </summary>
	public class Tax1099Misc : Tax
	{
		/// <summary>
		/// PAYER'S name, address, and phone
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
		/// RECIPIENT'S name and address
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// FATCA filing requirement
		/// </summary>
		[JsonPropertyName("foreignAccountTaxCompliance")]
		public bool ForeignAccountTaxCompliance { get; set; }

		/// <summary>
		/// Box 1, Rents
		/// </summary>
		[JsonPropertyName("rents")]
		public double Rents { get; set; }

		/// <summary>
		/// Box 2, Royalties
		/// </summary>
		[JsonPropertyName("royalties")]
		public double Royalties { get; set; }

		/// <summary>
		/// Box 3, Other income
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public double OtherIncome { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Fishing boat proceeds
		/// </summary>
		[JsonPropertyName("fishingBoatProceeds")]
		public double FishingBoatProceeds { get; set; }

		/// <summary>
		/// Box 6, Medical and health care payments
		/// </summary>
		[JsonPropertyName("medicalHealthPayment")]
		public double MedicalHealthPayment { get; set; }

		/// <summary>
		/// 2019 Box 7, Nonemployee compensation (IRS removed 2020)
		/// </summary>
		[JsonPropertyName("nonEmployeeCompensation")]
		public double NonEmployeeCompensation { get; set; }

		/// <summary>
		/// Box 7, Payer made direct sales of $5,000 or more of consumer products to a buyer (recipient) for resale
		/// </summary>
		[JsonPropertyName("payerDirectSales")]
		public bool PayerDirectSales { get; set; }

		/// <summary>
		/// Box 8, Substitute payments in lieu of dividends or interest
		/// </summary>
		[JsonPropertyName("substitutePayments")]
		public double SubstitutePayments { get; set; }

		/// <summary>
		/// Box 9, Crop insurance proceeds
		/// </summary>
		[JsonPropertyName("cropInsurance")]
		public double CropInsurance { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }

		/// <summary>
		/// Box 10, Gross proceeds paid to an attorney
		/// </summary>
		[JsonPropertyName("grossAttorney")]
		public double GrossAttorney { get; set; }

		/// <summary>
		/// Box 11, Fish purchased for resale
		/// </summary>
		[JsonPropertyName("fishPurchased")]
		public double FishPurchased { get; set; }

		/// <summary>
		/// Box 12, Section 409A deferrals
		/// </summary>
		[JsonPropertyName("section409ADeferrals")]
		public double Section409ADeferrals { get; set; }

		/// <summary>
		/// 2019 Box 15b, Section 409A income (IRS removed 2020)
		/// </summary>
		[JsonPropertyName("section409AIncome")]
		public double Section409AIncome { get; set; }

		/// <summary>
		/// Box 13, Excess golden parachute payments
		/// </summary>
		[JsonPropertyName("excessGolden")]
		public double ExcessGolden { get; set; }

		/// <summary>
		/// Box 14, Nonqualified Deferred Compensation
		/// </summary>
		[JsonPropertyName("nonQualifiedDeferredCompensation")]
		public double NonQualifiedDeferredCompensation { get; set; }

		/// <summary>
		/// Boxes 16-18, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }
	}
}

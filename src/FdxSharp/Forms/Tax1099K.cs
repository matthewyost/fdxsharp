using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-K, Merchant Card and Third-Party Network Payments
	/// </summary>
	public class Tax1099K : Tax
	{
		/// <summary>
		/// Filer's name, address, and phone
		/// </summary>
		[JsonPropertyName("filerNameAddress")]
		public NameAddressPhone? FilerNameAddress { get; set; }

		/// <summary>
		/// Check to indicate if FILER is a Payment Settlement Entity (PSE)
		/// </summary>
		[JsonPropertyName("paymentSettlementEntity")]
		public bool PaymentSettlementEntity { get; set; }

		/// <summary>
		/// Check to indicate if FILER is an Electronic Payment Facilitator (EPF) / Other third party
		/// </summary>
		[JsonPropertyName("electronicPaymentFacilitator")]
		public bool ElectronicPaymentFacilitator { get; set; }

		/// <summary>
		/// Check to indicate transactions reported are: Payment card
		/// </summary>
		[JsonPropertyName("paymentCard")]
		public bool PaymentCard { get; set; }

		/// <summary>
		/// Check to indicate transactions reported are: Third party network
		/// </summary>
		[JsonPropertyName("thirdPartyNetwork")]
		public bool ThirdPartyNetwork { get; set; }

		/// <summary>
		/// Payee's name and address
		/// </summary>
		[JsonPropertyName("payeeNameAddress")]
		public NameAddress? PayeeNameAddress { get; set; }

		/// <summary>
		/// PSE's name
		/// </summary>
		[JsonPropertyName("pseName")]
		public string? PseName { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// FILER'S TIN
		/// </summary>
		[JsonPropertyName("filerTin")]
		public string? FilerTin { get; set; }

		/// <summary>
		/// PAYEE'S TIN
		/// </summary>
		[JsonPropertyName("payeeTin")]
		public string? PayeeTin { get; set; }

		/// <summary>
		/// Box 1a, Gross amount of payment card/third party network transactions
		/// </summary>
		[JsonPropertyName("grossAmount")]
		public double GrossAmount { get; set; }

		/// <summary>
		/// Box 1b, Card Not Present Transactions
		/// </summary>
		[JsonPropertyName("cardNotPresent")]
		public double CardNotPresent { get; set; }

		/// <summary>
		/// Box 2, Merchant category code
		/// </summary>
		[JsonPropertyName("merchantCategoryCode")]
		public string? MerchantCategoryCode { get; set; }

		/// <summary>
		/// Box 3, Number of purchase transactions
		/// </summary>
		[JsonPropertyName("numberOfTransactions")]
		public double NumberOfTransactions { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Monthly amounts
		/// </summary>
		[JsonPropertyName("monthAmounts")]
		public MonthAmount[]? MonthAmounts { get; set; }

		/// <summary>
		/// Boxes 6-8, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// PSE's phone number
		/// </summary>
		[JsonPropertyName("psePhone")]
		public TelephoneNumberPlusExtension? PsePhone { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

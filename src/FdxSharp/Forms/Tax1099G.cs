using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-G, Certain Government Payments
	/// </summary>
	public class Tax1099G : Tax
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
		/// Box 1, Unemployment compensation
		/// </summary>
		[JsonPropertyName("unemploymentCompensation")]
		public double UnemploymentCompensation { get; set; }

		/// <summary>
		/// Box 2, State or local income tax refunds, credits, or offsets
		/// </summary>
		[JsonPropertyName("taxRefund")]
		public double TaxRefund { get; set; }

		/// <summary>
		/// Box 3, Box 2 amount is for tax year
		/// </summary>
		[JsonPropertyName("refundYear")]
		public int RefundYear { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, RTAA payments
		/// </summary>
		[JsonPropertyName("rtaaPayments")]
		public double RtaaPayments { get; set; }

		/// <summary>
		/// Box 6, Taxable grants
		/// </summary>
		[JsonPropertyName("grants")]
		public double Grants { get; set; }

		/// <summary>
		/// Box 7, Agriculture payments
		/// </summary>
		[JsonPropertyName("agriculturePayments")]
		public double AgriculturePayments { get; set; }

		/// <summary>
		/// Box 8, If checked, box 2 is trade or business income
		/// </summary>
		[JsonPropertyName("businessIncome")]
		public bool BusinessIncome { get; set; }

		/// <summary>
		/// Box 9, Market gain
		/// </summary>
		[JsonPropertyName("marketGain")]
		public double MarketGain { get; set; }

		/// <summary>
		/// Boxes 10-11, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

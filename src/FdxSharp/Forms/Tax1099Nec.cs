using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-NEC, Non-Employee Compensation
	/// </summary>
	public class Tax1099Nec : Tax
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
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }

		/// <summary>
		/// Box 1, Nonemployee compensation
		/// </summary>
		[JsonPropertyName("nonEmployeeCompensation")]
		public double NonEmployeeCompensation { get; set; }

		/// <summary>
		/// Box 2, Payer made direct sales of $5,000 or more of consumer products to a buyer (recipient) for resale
		/// </summary>
		[JsonPropertyName("payerDirectSales")]
		public bool PayerDirectSales { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Boxes 5-7, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }
	}
}

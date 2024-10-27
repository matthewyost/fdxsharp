using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-C, Cancellation of Debt
	/// </summary>
	public class Tax1099C : Tax
	{
		/// <summary>
		/// Creditor's name, address, and phone
		/// </summary>
		[JsonPropertyName("creditorNameAddress")]
		public NameAddressPhone? CreditorNameAddress { get; set; }

		/// <summary>
		/// CREDITOR'S TIN
		/// </summary>
		[JsonPropertyName("creditorTin")]
		public string? CreditorTin { get; set; }

		/// <summary>
		/// DEBTOR'S TIN
		/// </summary>
		[JsonPropertyName("debtorTin")]
		public string? DebtorTin { get; set; }

		/// <summary>
		/// Debtor's name and address
		/// </summary>
		[JsonPropertyName("debtorNameAddress")]
		public NameAddress? DebtorNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Date of identifiable event
		/// </summary>
		[JsonPropertyName("dateOfEvent")]
		public DateTime? DateOfEvent { get; set; }

		/// <summary>
		/// Box 2, Amount of debt discharged
		/// </summary>
		[JsonPropertyName("amountDischarged")]
		public double AmountDischarged { get; set; }

		/// <summary>
		/// Box 3, Interest if included in box 2
		/// </summary>
		[JsonPropertyName("interestIncluded")]
		public double InterestIncluded { get; set; }

		/// <summary>
		/// Box 4, Debt description
		/// </summary>
		[JsonPropertyName("debtDescription")]
		public string? DebtDescription { get; set; }

		/// <summary>
		/// Box 5, If checked, the debtor was personally liable for repayment of the debt
		/// </summary>
		[JsonPropertyName("personallyLiable")]
		public bool PersonallyLiable { get; set; }

		/// <summary>
		/// Box 6, Identifiable debt code
		/// </summary>
		[JsonPropertyName("debtCode")]
		public string? DebtCode { get; set; }

		/// <summary>
		/// Box 7, Fair market value of property
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }
	}
}

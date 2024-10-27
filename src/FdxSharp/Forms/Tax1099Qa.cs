using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-QA, Distributions From ABLE Accounts
	/// </summary>
	public class Tax1099Qa : Tax
	{
		/// <summary>
		/// PAYER'S name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone no.
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
		/// Recipient's name, street address, city or town, state or province, country, and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Gross distribution
		/// </summary>
		[JsonPropertyName("grossDistribution")]
		public double GrossDistribution { get; set; }

		/// <summary>
		/// Box 2, Earnings
		/// </summary>
		[JsonPropertyName("earnings")]
		public double Earnings { get; set; }

		/// <summary>
		/// Box 3, Basis
		/// </summary>
		[JsonPropertyName("basis")]
		public double Basis { get; set; }

		/// <summary>
		/// Box 4, Program-to-program transfer
		/// </summary>
		[JsonPropertyName("programTransfer")]
		public bool ProgramTransfer { get; set; }

		/// <summary>
		/// Box 5, Check if ABLE account terminated in current year
		/// </summary>
		[JsonPropertyName("terminated")]
		public bool Terminated { get; set; }

		/// <summary>
		/// Box 6, Check if the recipient is not the designated beneficiary
		/// </summary>
		[JsonPropertyName("notBeneficiary")]
		public bool NotBeneficiary { get; set; }
	}
}

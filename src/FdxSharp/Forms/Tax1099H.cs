using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-H, 2019 Health Coverage Tax Credit (HCTC) Advance Payments (IRS discontinued in 2020)
	/// </summary>
	public class Tax1099H : Tax
	{
		/// <summary>
		/// Issuer's name, address, and phone
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone? IssuerNameAddress { get; set; }

		/// <summary>
		/// ISSUER'S/PROVIDER'S federal identification number
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

		/// <summary>
		/// RECIPIENT'S identification number
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string? RecipientTin { get; set; }

		/// <summary>
		/// Recipient's name and address
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Box 1, Amount of HCTC advance payments
		/// </summary>
		[JsonPropertyName("advancePayments")]
		public double AdvancePayments { get; set; }

		/// <summary>
		/// Box 2, Number of months HCTC advance payments and reimbursement credits paid to you
		/// </summary>
		[JsonPropertyName("numberOfMonths")]
		public int NumberOfMonths { get; set; }

		/// <summary>
		/// Boxes 3-14, Payments by month
		/// </summary>
		[JsonPropertyName("payments")]
		public MonthAmount[]? Payments { get; set; }
	}
}

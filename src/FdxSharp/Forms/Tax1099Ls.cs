using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-LS, Reportable Life Insurance Sale
	/// </summary>
	public class Tax1099Ls : Tax
	{
		/// <summary>
		/// ACQUIRER's name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone no.
		/// </summary>
		[JsonPropertyName("acquirerNameAddress")]
		public NameAddressPhone? AcquirerNameAddress { get; set; }

		/// <summary>
		/// ACQUIRER's TIN
		/// </summary>
		[JsonPropertyName("acquirerTin")]
		public string? AcquirerTin { get; set; }

		/// <summary>
		/// PAYMENT RECIPIENT'S TIN
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string? RecipientTin { get; set; }

		/// <summary>
		/// PAYMENT RECIPIENT'S name, street address (including apt. no.), city or town, state or province, country, and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Policy number
		/// </summary>
		[JsonPropertyName("policyNumber")]
		public string? PolicyNumber { get; set; }

		/// <summary>
		/// Box 1, Amount paid to payment recipient
		/// </summary>
		[JsonPropertyName("payment")]
		public double Payment { get; set; }

		/// <summary>
		/// Box 2, Date of sale
		/// </summary>
		[JsonPropertyName("saleDate")]
		public DateTime? SaleDate { get; set; }

		/// <summary>
		/// Issuer's name
		/// </summary>
		[JsonPropertyName("issuerName")]
		public string? IssuerName { get; set; }

		/// <summary>
		/// Acquirer's information contact name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone no. (If different from ACQUIRER)
		/// </summary>
		[JsonPropertyName("contactNameAddress")]
		public NameAddressPhone? ContactNameAddress { get; set; }
	}
}

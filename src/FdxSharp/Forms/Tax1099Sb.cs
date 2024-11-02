using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-SB, Seller's Investment in Life Insurance Contract
	/// </summary>
	public class Tax1099Sb : Tax
	{
		/// <summary>
		/// ISSUER's name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone no.
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone? IssuerNameAddress { get; set; }

		/// <summary>
		/// ISSUER's TIN
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

		/// <summary>
		/// SELLER'S TIN
		/// </summary>
		[JsonPropertyName("sellerTin")]
		public string? SellerTin { get; set; }

		/// <summary>
		/// SELLER'S name, street address (including apt. no.), city or town, state or province, country and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("sellerNameAddress")]
		public NameAddress? SellerNameAddress { get; set; }

		/// <summary>
		/// Policy number
		/// </summary>
		[JsonPropertyName("policyNumber")]
		public string? PolicyNumber { get; set; }

		/// <summary>
		/// Box 1, Investment in contract
		/// </summary>
		[JsonPropertyName("contractInvestment")]
		public double ContractInvestment { get; set; }

		/// <summary>
		/// Box 2, Surrender amount
		/// </summary>
		[JsonPropertyName("surrenderAmount")]
		public double SurrenderAmount { get; set; }

		/// <summary>
		/// Issuer's information contact name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone no. (if different from ISSUER)
		/// </summary>
		[JsonPropertyName("contactNameAddress")]
		public NameAddressPhone? ContactNameAddress { get; set; }
	}
}

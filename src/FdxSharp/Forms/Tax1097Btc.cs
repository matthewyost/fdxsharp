using FdxSharp.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1097-BTC, Bond Tax Credit
	/// </summary>
	public class Tax1097Btc : Tax
	{
		/// <summary>
		/// Issuer's name, address, and phone.
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone IssuerNameAddress { get; set; }

		/// <summary>
		/// FORM 1097-BTC ISSUER'S TIN.
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string IssuerTin { get; set; }

		/// <summary>
		/// RECIPIENT'S TIN.
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string RecipientTin { get; set; }

		/// <summary>
		/// Recipient's name and address.
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress RecipientNameAddress { get; set; }

		/// <summary>
		/// Form 1097-BTC issuer is: Issuer of bond or its agent filing current year Form 1097-BTC for credit being reported.
		/// </summary>
		[JsonPropertyName("filingForCredit")]
		public bool FilingForCredit { get; set; }

		/// <summary>
		/// Form 1097-BTC issuer is: An entity or a person that received or should have received a current year Form 1097-BTC and is distributing part or all of that credit to others.
		/// </summary>
		[JsonPropertyName("asNominee")]
		public bool AsNominee { get; set; }

		/// <summary>
		/// Box 1, Total.
		/// </summary>
		[JsonPropertyName("total")]
		public double Total { get; set; }

		/// <summary>
		/// Box 2a, Code.
		/// </summary>
		[JsonPropertyName("bondCode")]
		public string BondCode { get; set; }

		/// <summary>
		/// Box 2b, Unique Identifier.
		/// </summary>
		[JsonPropertyName("uniqueId")]
		public string UniqueId { get; set; }

		/// <summary>
		/// Box 3, Bond type.
		/// </summary>
		[JsonPropertyName("bondType")]
		public string BondType { get; set; }

		/// <summary>
		/// Box 5, Amounts by month.
		/// </summary>
		[JsonPropertyName("amounts")]
		public List<MonthAmount> Amounts { get; set; }

		/// <summary>
		/// Box 6, Comments.
		/// </summary>
		[JsonPropertyName("comments")]
		public string Comments { get; set; }
	}
}

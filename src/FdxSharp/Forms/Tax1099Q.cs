using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-Q, Payments From Qualified Education Programs
	/// </summary>
	public class Tax1099Q : Tax
	{
		/// <summary>
		/// Payer's name, address, and phone
		/// </summary>
		[JsonPropertyName("payerNameAddress")]
		public NameAddressPhone? PayerNameAddress { get; set; }

		/// <summary>
		/// PAYER'S/TRUSTEE'S TIN
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
		/// Box 4, Trustee-to-trustee transfer
		/// </summary>
		[JsonPropertyName("trusteeToTrustee")]
		public bool TrusteeToTrustee { get; set; }

		/// <summary>
		/// Box 5a, Qualified tuition plan - Private
		/// </summary>
		[JsonPropertyName("tuitionPlanPrivate")]
		public bool TuitionPlanPrivate { get; set; }

		/// <summary>
		/// Box 5b, Qualified tuition plan - Public
		/// </summary>
		[JsonPropertyName("tuitionPlanPublic")]
		public bool TuitionPlanPublic { get; set; }

		/// <summary>
		/// Box 5c, Coverdell ESA
		/// </summary>
		[JsonPropertyName("coverdellEsa")]
		public bool CoverdellEsa { get; set; }

		/// <summary>
		/// Box 6, If this box is checked, the recipient is not the designated beneficiary
		/// </summary>
		[JsonPropertyName("recipientIsNotBeneficiary")]
		public bool RecipientIsNotBeneficiary { get; set; }
	}
}

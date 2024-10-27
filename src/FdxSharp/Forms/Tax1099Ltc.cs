using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-LTC, Long-Term Care and Accelerated Death Benefits
	/// </summary>
	public class Tax1099Ltc : Tax
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
		/// POLICYHOLDER'S TIN
		/// </summary>
		[JsonPropertyName("policyholderTin")]
		public string? PolicyholderTin { get; set; }

		/// <summary>
		/// Policyholder name and address
		/// </summary>
		[JsonPropertyName("policyHolderNameAddress")]
		public NameAddress? PolicyHolderNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Gross long-term care benefits paid
		/// </summary>
		[JsonPropertyName("ltcBenefits")]
		public double LtcBenefits { get; set; }

		/// <summary>
		/// Box 2, Accelerated death benefits paid
		/// </summary>
		[JsonPropertyName("deathBenefits")]
		public double DeathBenefits { get; set; }

		/// <summary>
		/// Box 3, Per diem
		/// </summary>
		[JsonPropertyName("perDiem")]
		public bool PerDiem { get; set; }

		/// <summary>
		/// Box 3, Reimbursed amount
		/// </summary>
		[JsonPropertyName("reimbursedAmount")]
		public bool ReimbursedAmount { get; set; }

		/// <summary>
		/// INSURED'S taxpayer identification no.
		/// </summary>
		[JsonPropertyName("insuredId")]
		public string? InsuredId { get; set; }

		/// <summary>
		/// Insured name and address
		/// </summary>
		[JsonPropertyName("insuredNameAddress")]
		public NameAddress? InsuredNameAddress { get; set; }

		/// <summary>
		/// Box 4, Qualified contract
		/// </summary>
		[JsonPropertyName("qualifiedContract")]
		public bool QualifiedContract { get; set; }

		/// <summary>
		/// Box 5, Chronically ill
		/// </summary>
		[JsonPropertyName("chronicallyIll")]
		public bool ChronicallyIll { get; set; }

		/// <summary>
		/// Box 5, Terminally ill
		/// </summary>
		[JsonPropertyName("terminallyIll")]
		public bool TerminallyIll { get; set; }

		/// <summary>
		/// Date certified
		/// </summary>
		[JsonPropertyName("dateCertified")]
		public DateTime? DateCertified { get; set; }
	}
}

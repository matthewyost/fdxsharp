using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-SA, Distributions From an HSA, Archer MSA, or Medicare Advantage MSA
	/// </summary>
	public class Tax1099Sa : Tax
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
		/// Box 1, Gross distribution
		/// </summary>
		[JsonPropertyName("grossDistribution")]
		public double GrossDistribution { get; set; }

		/// <summary>
		/// Box 2, Earnings on excess contributions
		/// </summary>
		[JsonPropertyName("earnings")]
		public double Earnings { get; set; }

		/// <summary>
		/// Box 3, Distribution code
		/// </summary>
		[JsonPropertyName("distributionCode")]
		public string? DistributionCode { get; set; }

		/// <summary>
		/// Box 4, FMV on date of death
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 5a, HSA
		/// </summary>
		[JsonPropertyName("hsa")]
		public bool Hsa { get; set; }

		/// <summary>
		/// Box 5b, Archer MSA
		/// </summary>
		[JsonPropertyName("archerAccount")]
		public bool ArcherAccount { get; set; }

		/// <summary>
		/// Box 5c, Medicare Advantage (MA) MSA
		/// </summary>
		[JsonPropertyName("medicalSavingsAccount")]
		public bool MedicalSavingsAccount { get; set; }
	}
}

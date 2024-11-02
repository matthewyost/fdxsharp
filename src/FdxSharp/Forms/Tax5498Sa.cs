using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 5498-SA, HSA, Archer MSA, or Medicare Advantage (MA) MSA Information
	/// </summary>
	public class Tax5498Sa : Tax
	{
		/// <summary>
		/// Trustee's name, address, and phone
		/// </summary>
		[JsonPropertyName("trusteeNameAddress")]
		public NameAddressPhone? TrusteeNameAddress { get; set; }

		/// <summary>
		/// TRUSTEE'S TIN
		/// </summary>
		[JsonPropertyName("trusteeTin")]
		public string? TrusteeTin { get; set; }

		/// <summary>
		/// PARTICIPANT'S TIN
		/// </summary>
		[JsonPropertyName("participantTin")]
		public string? ParticipantTin { get; set; }

		/// <summary>
		/// Participant's name and address
		/// </summary>
		[JsonPropertyName("participantNameAddress")]
		public NameAddress? ParticipantNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Employee or self-employed person's Archer MSA contributions made in current and following years for current year
		/// </summary>
		[JsonPropertyName("msaContributions")]
		public double MsaContributions { get; set; }

		/// <summary>
		/// Box 2, Total contributions made in current year
		/// </summary>
		[JsonPropertyName("totalContributions")]
		public double TotalContributions { get; set; }

		/// <summary>
		/// Box 3, Total HSA or Archer MSA contributions made in following year for current year
		/// </summary>
		[JsonPropertyName("totalPostYearEnd")]
		public double TotalPostYearEnd { get; set; }

		/// <summary>
		/// Box 4, Rollover contributions
		/// </summary>
		[JsonPropertyName("rolloverContributions")]
		public double RolloverContributions { get; set; }

		/// <summary>
		/// Box 5, Fair market value of HSA, Archer MSA, or Medicare Advantage (MA) MSA
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 6a, HSA
		/// </summary>
		[JsonPropertyName("hsa")]
		public bool Hsa { get; set; }

		/// <summary>
		/// Box 6b, Archer MSA
		/// </summary>
		[JsonPropertyName("archer")]
		public bool Archer { get; set; }

		/// <summary>
		/// Box 6c, Medicare Advantage (MA) MSA
		/// </summary>
		[JsonPropertyName("maMsa")]
		public bool MaMsa { get; set; }
	}
}

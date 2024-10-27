using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 5498, IRA Contribution Information
	/// </summary>
	public class Tax5498 : Tax
	{
		/// <summary>
		/// Issuer's name, address, and phone
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone? IssuerNameAddress { get; set; }

		/// <summary>
		/// TRUSTEE'S or ISSUER'S TIN
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

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
		/// Box 1, IRA contributions
		/// </summary>
		[JsonPropertyName("iraContributions")]
		public double IraContributions { get; set; }

		/// <summary>
		/// Box 2, Rollover contributions
		/// </summary>
		[JsonPropertyName("rolloverContributions")]
		public double RolloverContributions { get; set; }

		/// <summary>
		/// Box 3, Roth IRA conversion amount
		/// </summary>
		[JsonPropertyName("rothIraConversion")]
		public double RothIraConversion { get; set; }

		/// <summary>
		/// Box 4, Recharacterized contributions
		/// </summary>
		[JsonPropertyName("recharacterizedContributions")]
		public double RecharacterizedContributions { get; set; }

		/// <summary>
		/// Box 5, Fair market value of account
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 6, Life insurance cost included in box 1
		/// </summary>
		[JsonPropertyName("lifeInsuranceCost")]
		public double LifeInsuranceCost { get; set; }

		/// <summary>
		/// Box 7a, IRA
		/// </summary>
		[JsonPropertyName("ira")]
		public bool Ira { get; set; }

		/// <summary>
		/// Box 7b, SEP
		/// </summary>
		[JsonPropertyName("sep")]
		public bool Sep { get; set; }

		/// <summary>
		/// Box 7c, SIMPLE
		/// </summary>
		[JsonPropertyName("simple")]
		public bool Simple { get; set; }

		/// <summary>
		/// Box 7d, ROTHIRA
		/// </summary>
		[JsonPropertyName("rothIra")]
		public bool RothIra { get; set; }

		/// <summary>
		/// Box 8, SEP contributions
		/// </summary>
		[JsonPropertyName("sepContributions")]
		public double SepContributions { get; set; }

		/// <summary>
		/// Box 9, SIMPLE contributions
		/// </summary>
		[JsonPropertyName("simpleContributions")]
		public double SimpleContributions { get; set; }

		/// <summary>
		/// Box 10, Roth IRA contributions
		/// </summary>
		[JsonPropertyName("rothIraContributions")]
		public double RothIraContributions { get; set; }

		/// <summary>
		/// Box 11, If checked, required minimum distribution for next year
		/// </summary>
		[JsonPropertyName("rmdNextYear")]
		public bool RmdNextYear { get; set; }

		/// <summary>
		/// Box 12a, RMD date
		/// </summary>
		[JsonPropertyName("rmdDate")]
		public DateTime? RmdDate { get; set; }

		/// <summary>
		/// Box 12b, RMD amount
		/// </summary>
		[JsonPropertyName("rmdAmount")]
		public double RmdAmount { get; set; }

		/// <summary>
		/// Box 13a, Postponed contribution
		/// </summary>
		[JsonPropertyName("postponedContribution")]
		public double PostponedContribution { get; set; }

		/// <summary>
		/// Box 13b, Year
		/// </summary>
		[JsonPropertyName("postponedYear")]
		public int? PostponedYear { get; set; }

		/// <summary>
		/// Box 13c, Code
		/// </summary>
		[JsonPropertyName("postponedCode")]
		public string? PostponedCode { get; set; }

		/// <summary>
		/// Box 14a, Repayments
		/// </summary>
		[JsonPropertyName("repayments")]
		public double Repayments { get; set; }

		/// <summary>
		/// Box 14b, Code
		/// </summary>
		[JsonPropertyName("repayCode")]
		public string? RepayCode { get; set; }

		/// <summary>
		/// Box 15a, FMV of certain specified assets
		/// </summary>
		[JsonPropertyName("fmvSpecifiedAssets")]
		public double FmvSpecifiedAssets { get; set; }

		/// <summary>
		/// Box 15b, Code(s)
		/// </summary>
		[JsonPropertyName("specifiedCodes")]
		public string? SpecifiedCodes { get; set; }
	}
}

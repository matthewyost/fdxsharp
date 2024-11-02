using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098-Q, Qualifying Longevity Annuity Contract Information
	/// </summary>
	public class Tax1098Q : Tax
	{
		/// <summary>
		/// ISSUER's name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone number
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone? IssuerNameAddress { get; set; }

		/// <summary>
		/// ISSUER's TIN
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string? IssuerTin { get; set; }

		/// <summary>
		/// PARTICIPANT'S TIN
		/// </summary>
		[JsonPropertyName("participantTin")]
		public string? ParticipantTin { get; set; }

		/// <summary>
		/// PARTICIPANT'S name, street address (including apt. no.), city or town, state or province, country and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("participantNameAddress")]
		public NameAddress? ParticipantNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Plan number
		/// </summary>
		[JsonPropertyName("planNumber")]
		public string? PlanNumber { get; set; }

		/// <summary>
		/// Plan name
		/// </summary>
		[JsonPropertyName("planName")]
		public string? PlanName { get; set; }

		/// <summary>
		/// Plan sponsor's EIN
		/// </summary>
		[JsonPropertyName("planSponsorId")]
		public string? PlanSponsorId { get; set; }

		/// <summary>
		/// Box 1a, Annuity amount on start date
		/// </summary>
		[JsonPropertyName("annuityAmount")]
		public double AnnuityAmount { get; set; }

		/// <summary>
		/// Box 1b, Annuity start date
		/// </summary>
		[JsonPropertyName("startDate")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Box 2, Start date may be accelerated
		/// </summary>
		[JsonPropertyName("canBeAccelerated")]
		public bool CanBeAccelerated { get; set; }

		/// <summary>
		/// Box 3, Total premiums
		/// </summary>
		[JsonPropertyName("totalPremiums")]
		public double TotalPremiums { get; set; }

		/// <summary>
		/// Box 4, Fair market value of qualifying longevity annuity contract (FMV of QLAC)
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 5, Total monthly premiums paid for the contract and date of the last payment in the month
		/// </summary>
		[JsonPropertyName("premiums")]
		public DateAmount[]? Premiums { get; set; }
	}
}

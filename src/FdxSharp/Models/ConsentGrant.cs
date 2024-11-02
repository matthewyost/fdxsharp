using FdxSharp.Enums;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Consent Grant
	/// </summary>
	public class ConsentGrant
	{
		/// <summary>
		/// The persistent identifier of the consent
		/// </summary>
		[JsonPropertyName("id")]
		public string? Id { get; set; }

		/// <summary>
		/// The current status of the consent
		/// </summary>
		[JsonPropertyName("status")]
		public ConsentGrantStatusType? Status { get; set; }

		/// <summary>
		/// The non-end user parties participating in the Consent Grant
		/// </summary>
		[JsonPropertyName("parties")]
		public ConsentGrantParty[]? Parties { get; set; }

		/// <summary>
		/// When the consent was initially granted
		/// </summary>
		[JsonPropertyName("createdTime")]
		public DateTime? CreatedTime { get; set; }

		/// <summary>
		/// When the consent grant will become expired
		/// </summary>
		[JsonPropertyName("expirationTime")]
		public DateTime? ExpirationTime { get; set; }

		/// <summary>
		/// The type of duration of the consent
		/// </summary>
		[JsonPropertyName("durationType")]
		public ConsentDurationType? DurationType { get; set; }

		/// <summary>
		/// The consent duration in days from day of original grant
		/// </summary>
		[JsonPropertyName("durationPeriod")]
		public int? DurationPeriod { get; set; }

		/// <summary>
		/// Period, in days, for which historical data may be requested; measured from request time, not grant time
		/// </summary>
		[JsonPropertyName("lookbackPeriod")]
		public int? LookbackPeriod { get; set; }

		/// <summary>
		/// The permissioned resource entities
		/// </summary>
		[JsonPropertyName("resources")]
		public ConsentGrantResource[]? Resources { get; set; }
	}
}

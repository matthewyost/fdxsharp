using System;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Health Insurance Marketplace Covered Individual, Used on Form 1095-A Part II
	/// </summary>
	public class HealthInsuranceMarketplaceCoveredIndividual
	{
		/// <summary>
		/// Covered individual name.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Covered individual SSN.
		/// </summary>
		[JsonPropertyName("tin")]
		public string Tin { get; set; }

		/// <summary>
		/// Covered individual date of birth.
		/// </summary>
		[JsonPropertyName("dateOfBirth")]
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// Coverage start date.
		/// </summary>
		[JsonPropertyName("policyStartDate")]
		public DateTime PolicyStartDate { get; set; }

		/// <summary>
		/// Coverage termination date.
		/// </summary>
		[JsonPropertyName("policyTerminationDate")]
		public DateTime? PolicyTerminationDate { get; set; }
	}
}

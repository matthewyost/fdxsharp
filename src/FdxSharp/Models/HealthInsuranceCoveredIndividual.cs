using FdxSharp.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Health Insurance Covered Individual, Used on Form 1095-B Part IV and Form 1095-C Part III
	/// </summary>
	public class HealthInsuranceCoveredIndividual
	{
		/// <summary>
		/// Name of responsible individual.
		/// </summary>
		[JsonPropertyName("name")]
		public IndividualName Name { get; set; }

		/// <summary>
		/// Social security number or other TIN.
		/// </summary>
		[JsonPropertyName("tin")]
		public string Tin { get; set; }

		/// <summary>
		/// Date of birth.
		/// </summary>
		[JsonPropertyName("dateOfBirth")]
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// Covered all 12 months.
		/// </summary>
		[JsonPropertyName("coveredAll12Months")]
		public bool CoveredAll12Months { get; set; }

		/// <summary>
		/// Months covered.
		/// </summary>
		[JsonPropertyName("coveredMonths")]
		public List<MonthAbbreviationType> CoveredMonths { get; set; }
	}
}

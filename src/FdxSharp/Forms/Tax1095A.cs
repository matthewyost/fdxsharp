using FdxSharp.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1095-A, Health Insurance Marketplace Statement
	/// </summary>
	public class Tax1095A : Tax
	{
		/// <summary>
		/// Box 1, Marketplace identifier.
		/// </summary>
		[JsonPropertyName("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Box 2, Marketplace-assigned policy number.
		/// </summary>
		[JsonPropertyName("marketplacePolicyNumber")]
		public string MarketplacePolicyNumber { get; set; }

		/// <summary>
		/// Box 3, Policy issuer's name.
		/// </summary>
		[JsonPropertyName("policyIssuerName")]
		public string PolicyIssuerName { get; set; }

		/// <summary>
		/// Box 4, Recipient's name.
		/// </summary>
		[JsonPropertyName("recipientName")]
		public string RecipientName { get; set; }

		/// <summary>
		/// Box 5, Recipient's SSN.
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string RecipientTin { get; set; }

		/// <summary>
		/// Box 6, Recipient's date of birth.
		/// </summary>
		[JsonPropertyName("recipientDateOfBirth")]
		public DateTime RecipientDateOfBirth { get; set; }

		/// <summary>
		/// Box 7, Recipient's spouse's name.
		/// </summary>
		[JsonPropertyName("spouseName")]
		public string SpouseName { get; set; }

		/// <summary>
		/// Box 8, Recipient's spouse's SSN.
		/// </summary>
		[JsonPropertyName("spouseTin")]
		public string SpouseTin { get; set; }

		/// <summary>
		/// Box 9, Recipient's spouse's date of birth.
		/// </summary>
		[JsonPropertyName("spouseDateOfBirth")]
		public DateTime SpouseDateOfBirth { get; set; }

		/// <summary>
		/// Box 10, Policy start date.
		/// </summary>
		[JsonPropertyName("policyStartDate")]
		public DateTime PolicyStartDate { get; set; }

		/// <summary>
		/// Box 11, Policy termination date.
		/// </summary>
		[JsonPropertyName("policyTerminationDate")]
		public DateTime PolicyTerminationDate { get; set; }

		/// <summary>
		/// Boxes 12-15, Recipient address.
		/// </summary>
		[JsonPropertyName("recipientAddress")]
		public Address RecipientAddress { get; set; }

		/// <summary>
		/// Boxes 16+, Covered Individuals.
		/// </summary>
		[JsonPropertyName("coveredIndividuals")]
		public List<HealthInsuranceMarketplaceCoveredIndividual> CoveredIndividuals { get; set; }

		/// <summary>
		/// Boxes 21-33, Coverage Information.
		/// </summary>
		[JsonPropertyName("coverages")]
		public List<HealthInsuranceCoverage> Coverages { get; set; }
	}
}

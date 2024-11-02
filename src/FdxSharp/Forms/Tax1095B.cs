using FdxSharp.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1095-B, Health Coverage
	/// </summary>
	public class Tax1095B : Tax
	{
		/// <summary>
		/// Box 1, Name of responsible individual.
		/// </summary>
		[JsonPropertyName("responsibleName")]
		public IndividualName ResponsibleName { get; set; }

		/// <summary>
		/// Box 2, Social security number (SSN or other TIN).
		/// </summary>
		[JsonPropertyName("responsibleTin")]
		public string ResponsibleTin { get; set; }

		/// <summary>
		/// Box 3, Date of birth (if SSN or other TIN is not available).
		/// </summary>
		[JsonPropertyName("responsibleDateOfBirth")]
		public DateTime ResponsibleDateOfBirth { get; set; }

		/// <summary>
		/// Boxes 4-7, Address of responsible individual.
		/// </summary>
		[JsonPropertyName("responsibleAddress")]
		public Address ResponsibleAddress { get; set; }

		/// <summary>
		/// Box 8, Enter letter identifying Origin of the Health Coverage.
		/// </summary>
		[JsonPropertyName("originOfHealthCoverageCode")]
		public string OriginOfHealthCoverageCode { get; set; }

		/// <summary>
		/// Boxes 10, 12-15, Employer name and address.
		/// </summary>
		[JsonPropertyName("employerNameAddress")]
		public NameAddress EmployerNameAddress { get; set; }

		/// <summary>
		/// Box 11, Employer identification number (EIN).
		/// </summary>
		[JsonPropertyName("employerTin")]
		public string EmployerTin { get; set; }

		/// <summary>
		/// Boxes 16, 18-22, Issuer name, address, and phone.
		/// </summary>
		[JsonPropertyName("issuerNameAddress")]
		public NameAddressPhone IssuerNameAddress { get; set; }

		/// <summary>
		/// Box 17, Employer identification number (EIN).
		/// </summary>
		[JsonPropertyName("issuerTin")]
		public string IssuerTin { get; set; }

		/// <summary>
		/// Boxes 23+, Covered Individuals.
		/// </summary>
		[JsonPropertyName("coveredIndividuals")]
		public List<HealthInsuranceCoveredIndividual> CoveredIndividuals { get; set; }
	}
}

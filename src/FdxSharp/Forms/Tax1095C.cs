using FdxSharp.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1095-C, Employer-Provided Health Insurance Offer and Coverage
	/// </summary>
	public class Tax1095C : Tax
	{
		/// <summary>
		/// Box 1, Employee name.
		/// </summary>
		[JsonPropertyName("employeeName")]
		public IndividualName EmployeeName { get; set; }

		/// <summary>
		/// Box 2, Social security number (SSN).
		/// </summary>
		[JsonPropertyName("tin")]
		public string Tin { get; set; }

		/// <summary>
		/// Boxes 3-6, Employee address.
		/// </summary>
		[JsonPropertyName("employeeAddress")]
		public Address EmployeeAddress { get; set; }

		/// <summary>
		/// Boxes 7, 9-13, Employer name, address, and phone.
		/// </summary>
		[JsonPropertyName("employerNameAddress")]
		public NameAddressPhone EmployerNameAddress { get; set; }

		/// <summary>
		/// Box 8, Employer identification number (EIN).
		/// </summary>
		[JsonPropertyName("employerTin")]
		public string EmployerTin { get; set; }

		/// <summary>
		/// Self Insured Coverage.
		/// </summary>
		[JsonPropertyName("selfInsuredCoverage")]
		public bool SelfInsuredCoverage { get; set; }

		/// <summary>
		/// Boxes 14-16, Employee Offer of Coverage.
		/// </summary>
		[JsonPropertyName("offersOfCoverage")]
		public List<OfferOfHealthInsuranceCoverage> OffersOfCoverage { get; set; }

		/// <summary>
		/// Employee's Age on January 1.
		/// </summary>
		[JsonPropertyName("employeeAge")]
		public int EmployeeAge { get; set; }

		/// <summary>
		/// Plan Start Month.
		/// </summary>
		[JsonPropertyName("planStartMonth")]
		public int PlanStartMonth { get; set; }

		/// <summary>
		/// Boxes 17+, Covered Individuals.
		/// </summary>
		[JsonPropertyName("coveredIndividuals")]
		public List<HealthInsuranceCoveredIndividual> CoveredIndividuals { get; set; }
	}
}

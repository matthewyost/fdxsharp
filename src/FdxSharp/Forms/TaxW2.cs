using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form W-2, Wage and Tax Statement
	/// </summary>
	public class TaxW2 : Tax
	{
		/// <summary>
		/// Employee's social security number
		/// </summary>
		[JsonPropertyName("employeeTin")]
		public string? EmployeeTin { get; set; }

		/// <summary>
		/// Employer identification number (EIN)
		/// </summary>
		[JsonPropertyName("employerTin")]
		public string? EmployerTin { get; set; }

		/// <summary>
		/// Employer's name and address
		/// </summary>
		[JsonPropertyName("employerNameAddress")]
		public NameAddress? EmployerNameAddress { get; set; }

		/// <summary>
		/// Control number
		/// </summary>
		[JsonPropertyName("controlNumber")]
		public string? ControlNumber { get; set; }

		/// <summary>
		/// Employee name
		/// </summary>
		[JsonPropertyName("employeeName")]
		public IndividualName? EmployeeName { get; set; }

		/// <summary>
		/// Employee's address
		/// </summary>
		[JsonPropertyName("employeeAddress")]
		public Address? EmployeeAddress { get; set; }

		/// <summary>
		/// Box 1, Wages, tips, other compensation
		/// </summary>
		[JsonPropertyName("wages")]
		public double Wages { get; set; }

		/// <summary>
		/// Box 2, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 3, Social security wages
		/// </summary>
		[JsonPropertyName("socialSecurityWages")]
		public double SocialSecurityWages { get; set; }

		/// <summary>
		/// Box 4, Social security tax withheld
		/// </summary>
		[JsonPropertyName("socialSecurityTaxWithheld")]
		public double SocialSecurityTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Medicare wages and tips
		/// </summary>
		[JsonPropertyName("medicareWages")]
		public double MedicareWages { get; set; }

		/// <summary>
		/// Box 6, Medicare tax withheld
		/// </summary>
		[JsonPropertyName("medicareTaxWithheld")]
		public double MedicareTaxWithheld { get; set; }

		/// <summary>
		/// Box 7, Social security tips
		/// </summary>
		[JsonPropertyName("socialSecurityTips")]
		public double SocialSecurityTips { get; set; }

		/// <summary>
		/// Box 8, Allocated tips
		/// </summary>
		[JsonPropertyName("allocatedTips")]
		public double AllocatedTips { get; set; }

		/// <summary>
		/// Box 10, Dependent care benefits
		/// </summary>
		[JsonPropertyName("dependentCareBenefit")]
		public double DependentCareBenefit { get; set; }

		/// <summary>
		/// Box 11, Nonqualified plans
		/// </summary>
		[JsonPropertyName("nonQualifiedPlan")]
		public double NonQualifiedPlan { get; set; }

		/// <summary>
		/// Box 12, Codes and amounts
		/// </summary>
		[JsonPropertyName("codes")]
		public CodeAmount[]? Codes { get; set; }

		/// <summary>
		/// Box 13, Statutory employee
		/// </summary>
		[JsonPropertyName("statutory")]
		public bool Statutory { get; set; }

		/// <summary>
		/// Box 13, Retirement plan
		/// </summary>
		[JsonPropertyName("retirementPlan")]
		public bool RetirementPlan { get; set; }

		/// <summary>
		/// Box 13, Third-party sick pay
		/// </summary>
		[JsonPropertyName("thirdPartySickPay")]
		public bool ThirdPartySickPay { get; set; }

		/// <summary>
		/// Employee Stock Purchase Plan Qualified Disposition amount
		/// </summary>
		[JsonPropertyName("esppQualified")]
		public double EsppQualified { get; set; }

		/// <summary>
		/// Employee Stock Purchase Plan Nonqualified Disposition amount
		/// </summary>
		[JsonPropertyName("esppNonQualified")]
		public double EsppNonQualified { get; set; }

		/// <summary>
		/// Box 14, Other descriptions and amounts
		/// </summary>
		[JsonPropertyName("other")]
		public DescriptionAmount[]? Other { get; set; }

		/// <summary>
		/// Boxes 15-17, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Boxes 18-20, Local tax withholding
		/// </summary>
		[JsonPropertyName("localTaxWithholding")]
		public LocalTaxWithholding[]? LocalTaxWithholding { get; set; }
	}
}

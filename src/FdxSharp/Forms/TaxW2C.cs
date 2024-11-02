using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form W-2c, IRS form W-2c, Corrected Wage and Tax Statement
	/// </summary>
	public class TaxW2C : Tax
	{
		/// <summary>
		/// Box a, Employer's name, address, and ZIP code
		/// </summary>
		[JsonPropertyName("employerNameAddress")]
		public NameAddress? EmployerNameAddress { get; set; }

		/// <summary>
		/// Box b, Employer's Federal EIN
		/// </summary>
		[JsonPropertyName("employerTin")]
		public string? EmployerTin { get; set; }

		/// <summary>
		/// Box d, Employee's correct SSN
		/// </summary>
		[JsonPropertyName("employeeTin")]
		public string? EmployeeTin { get; set; }

		/// <summary>
		/// Box e, Corrected SSN and/or name
		/// </summary>
		[JsonPropertyName("correctedTinOrName")]
		public bool CorrectedTinOrName { get; set; }

		/// <summary>
		/// Box f, Employee's previously reported SSN
		/// </summary>
		[JsonPropertyName("previousEmployeeTin")]
		public string? PreviousEmployeeTin { get; set; }

		/// <summary>
		/// Box g, Employee's previously reported name
		/// </summary>
		[JsonPropertyName("previousEmployeeName")]
		public IndividualName? PreviousEmployeeName { get; set; }

		/// <summary>
		/// Box h, Employee's name
		/// </summary>
		[JsonPropertyName("employeeName")]
		public IndividualName? EmployeeName { get; set; }

		/// <summary>
		/// Box I, Employee's address and ZIP code
		/// </summary>
		[JsonPropertyName("employeeAddress")]
		public Address? EmployeeAddress { get; set; }

		/// <summary>
		/// Boxes 1-20 of Previously reported Wage and Tax Statement
		/// </summary>
		[JsonPropertyName("originalW2")]
		public TaxW2? OriginalW2 { get; set; }

		/// <summary>
		/// Boxes 1-20 of Correct information Wage and Tax Statement
		/// </summary>
		[JsonPropertyName("correctedW2")]
		public TaxW2? CorrectedW2 { get; set; }
	}
}

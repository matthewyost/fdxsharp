using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 3921, Exercise of an Incentive Stock Option Under Section 422(b)
	/// </summary>
	public class Tax3921 : Tax
	{
		/// <summary>
		/// TRANSFEROR'S name, street address, city or town, state or province, country and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("transferorNameAddress")]
		public NameAddress? TransferorNameAddress { get; set; }

		/// <summary>
		/// TRANSFEROR'S TIN
		/// </summary>
		[JsonPropertyName("transferorTin")]
		public string? TransferorTin { get; set; }

		/// <summary>
		/// EMPLOYEE'S TIN
		/// </summary>
		[JsonPropertyName("employeeTin")]
		public string? EmployeeTin { get; set; }

		/// <summary>
		/// EMPLOYEE'S name, street address (including apt. no.), city or town, state or province, country and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("employeeNameAddress")]
		public NameAddress? EmployeeNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Date option granted
		/// </summary>
		[JsonPropertyName("optionGrantDate")]
		public DateTime? OptionGrantDate { get; set; }

		/// <summary>
		/// Box 2, Date option exercised
		/// </summary>
		[JsonPropertyName("optionExerciseDate")]
		public DateTime? OptionExerciseDate { get; set; }

		/// <summary>
		/// Box 3, Exercise price per share
		/// </summary>
		[JsonPropertyName("exercisePrice")]
		public double ExercisePrice { get; set; }

		/// <summary>
		/// Box 4, Fair market value per share on exercise date
		/// </summary>
		[JsonPropertyName("exerciseMarketValue")]
		public double ExerciseMarketValue { get; set; }

		/// <summary>
		/// Box 5, Number of shares transferred
		/// </summary>
		[JsonPropertyName("numberOfShares")]
		public double NumberOfShares { get; set; }

		/// <summary>
		/// Box 6, If other than TRANSFEROR, name and address of corporation whose stock is begin transferred
		/// </summary>
		[JsonPropertyName("corporateNameAddress")]
		public NameAddress? CorporateNameAddress { get; set; }

		/// <summary>
		/// Box 6, If other than TRANSFEROR, TIN of corporation whose stock is begin transferred
		/// </summary>
		[JsonPropertyName("corporateTin")]
		public string? CorporateTin { get; set; }
	}
}

using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 3922, Transfer of Stock Acquired Through an Employee Stock Purchase Plan under Section 423(c)
	/// </summary>
	public class Tax3922 : Tax
	{
		/// <summary>
		/// CORPORATION'S name, street address, city or town, state or province, country and ZIP or foreign postal code
		/// </summary>
		[JsonPropertyName("corporationNameAddress")]
		public NameAddress? CorporationNameAddress { get; set; }

		/// <summary>
		/// CORPORATION'S TIN
		/// </summary>
		[JsonPropertyName("corporationTin")]
		public string? CorporationTin { get; set; }

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
		/// Box 3, Fair market value per share on grant date
		/// </summary>
		[JsonPropertyName("grantMarketValue")]
		public double GrantMarketValue { get; set; }

		/// <summary>
		/// Box 4, Fair market value per share on exercise date
		/// </summary>
		[JsonPropertyName("exerciseMarketValue")]
		public double ExerciseMarketValue { get; set; }

		/// <summary>
		/// Box 5, Exercise price paid per share
		/// </summary>
		[JsonPropertyName("exercisePrice")]
		public double ExercisePrice { get; set; }

		/// <summary>
		/// Box 6, Number of shares transferred
		/// </summary>
		[JsonPropertyName("numberOfShares")]
		public double NumberOfShares { get; set; }

		/// <summary>
		/// Box 7, Date legal title transferred
		/// </summary>
		[JsonPropertyName("titleTransferDate")]
		public DateTime? TitleTransferDate { get; set; }

		/// <summary>
		/// Box 8, Exercise price per share determined as if the option was exercised on the option granted date
		/// </summary>
		[JsonPropertyName("grantDateExercisePrice")]
		public double GrantDateExercisePrice { get; set; }
	}
}

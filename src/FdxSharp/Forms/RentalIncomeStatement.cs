using FdxSharp.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Rental Income Statement, Rental Income Statement for IRS Form 1040 Schedule E
	/// </summary>
	public class RentalIncomeStatement : Tax
	{
		/// <summary>
		/// Box 1a, Physical address of property (street, city, state, ZIP code)
		/// </summary>
		[JsonPropertyName("propertyAddress")]
		public Address? PropertyAddress { get; set; }

		/// <summary>
		/// Box 3, Rents received
		/// </summary>
		[JsonPropertyName("rents")]
		public double Rents { get; set; }

		/// <summary>
		/// Box 5, Advertising
		/// </summary>
		[JsonPropertyName("advertising")]
		public double Advertising { get; set; }

		/// <summary>
		/// Box 6, Auto and travel
		/// </summary>
		[JsonPropertyName("auto")]
		public double Auto { get; set; }

		/// <summary>
		/// Box 7, Cleaning and maintenance
		/// </summary>
		[JsonPropertyName("cleaning")]
		public double Cleaning { get; set; }

		/// <summary>
		/// Box 8, Commissions
		/// </summary>
		[JsonPropertyName("commissions")]
		public double Commissions { get; set; }

		/// <summary>
		/// Box 9, Insurance
		/// </summary>
		[JsonPropertyName("insurance")]
		public double Insurance { get; set; }

		/// <summary>
		/// Box 10, Legal and other professional fees
		/// </summary>
		[JsonPropertyName("legal")]
		public double Legal { get; set; }

		/// <summary>
		/// Box 11, Management fees
		/// </summary>
		[JsonPropertyName("managementFees")]
		public double ManagementFees { get; set; }

		/// <summary>
		/// Box 12, Mortgage interest paid to banks, etc.
		/// </summary>
		[JsonPropertyName("mortgageInterest")]
		public double MortgageInterest { get; set; }

		/// <summary>
		/// Box 13, Other interest
		/// </summary>
		[JsonPropertyName("otherInterest")]
		public double OtherInterest { get; set; }

		/// <summary>
		/// Box 14, Repairs
		/// </summary>
		[JsonPropertyName("repairs")]
		public double Repairs { get; set; }

		/// <summary>
		/// Box 15, Supplies
		/// </summary>
		[JsonPropertyName("supplies")]
		public double Supplies { get; set; }

		/// <summary>
		/// Box 16, Taxes
		/// </summary>
		[JsonPropertyName("taxes")]
		public double Taxes { get; set; }

		/// <summary>
		/// Box 17, Utilities
		/// </summary>
		[JsonPropertyName("utilities")]
		public double Utilities { get; set; }

		/// <summary>
		/// Box 18, Depreciation
		/// </summary>
		[JsonPropertyName("depreciationExpense")]
		public double DepreciationExpense { get; set; }

		/// <summary>
		/// Box 19, Other expenses
		/// </summary>
		[JsonPropertyName("otherExpenses")]
		public List<DescriptionAmount>? OtherExpenses { get; set; }

		/// <summary>
		/// Capital expenditures, for use in calculating Depreciation
		/// </summary>
		[JsonPropertyName("capitalExpenditures")]
		public List<DateAmount>? CapitalExpenditures { get; set; }
	}
}

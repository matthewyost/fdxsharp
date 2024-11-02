using FdxSharp.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Business Income Statement, Business Income Statement for IRS Form 1040 Schedule C
	/// </summary>
	public class BusinessIncomeStatement : Tax
	{
		/// <summary>
		/// Box C, Business name
		/// </summary>
		[JsonPropertyName("businessName")]
		public string? BusinessName { get; set; }

		/// <summary>
		/// Box 1, Gross receipts or sales
		/// </summary>
		[JsonPropertyName("sales")]
		public double Sales { get; set; }

		/// <summary>
		/// Box 2, Returns and allowances
		/// </summary>
		[JsonPropertyName("returns")]
		public double Returns { get; set; }

		/// <summary>
		/// Box 6, Other income, including federal and state gasoline or fuel tax credit or refund
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public List<DescriptionAmount>? OtherIncome { get; set; }

		/// <summary>
		/// Box 8, Advertising
		/// </summary>
		[JsonPropertyName("advertising")]
		public double Advertising { get; set; }

		/// <summary>
		/// Box 9, Car and truck expenses
		/// </summary>
		[JsonPropertyName("carAndTruck")]
		public double CarAndTruck { get; set; }

		/// <summary>
		/// Box 10, Commissions and fees
		/// </summary>
		[JsonPropertyName("commissions")]
		public double Commissions { get; set; }

		/// <summary>
		/// Box 11, Contract labor
		/// </summary>
		[JsonPropertyName("contractLabor")]
		public double ContractLabor { get; set; }

		/// <summary>
		/// Box 12, Depletion
		/// </summary>
		[JsonPropertyName("depletion")]
		public double Depletion { get; set; }

		/// <summary>
		/// Box 13, Depreciation
		/// </summary>
		[JsonPropertyName("depreciation")]
		public double Depreciation { get; set; }

		/// <summary>
		/// Box 14, Employee benefit programs
		/// </summary>
		[JsonPropertyName("employeeBenefits")]
		public double EmployeeBenefits { get; set; }

		/// <summary>
		/// Box 15, Insurance
		/// </summary>
		[JsonPropertyName("insurance")]
		public double Insurance { get; set; }

		/// <summary>
		/// Box 16a, Mortgage interest
		/// </summary>
		[JsonPropertyName("mortgageInterest")]
		public double MortgageInterest { get; set; }

		/// <summary>
		/// Box 16b, Other interest
		/// </summary>
		[JsonPropertyName("otherInterest")]
		public double OtherInterest { get; set; }

		/// <summary>
		/// Box 17, Legal and professional services
		/// </summary>
		[JsonPropertyName("legal")]
		public double Legal { get; set; }

		/// <summary>
		/// Box 18, Office expense
		/// </summary>
		[JsonPropertyName("office")]
		public double Office { get; set; }

		/// <summary>
		/// Box 19, Pension and profit-sharing plans
		/// </summary>
		[JsonPropertyName("pension")]
		public double Pension { get; set; }

		/// <summary>
		/// Box 20a, Equipment rent
		/// </summary>
		[JsonPropertyName("equipmentRent")]
		public double EquipmentRent { get; set; }

		/// <summary>
		/// Box 20b, Other rent
		/// </summary>
		[JsonPropertyName("otherRent")]
		public double OtherRent { get; set; }

		/// <summary>
		/// Box 21, Repairs and maintenance
		/// </summary>
		[JsonPropertyName("repairs")]
		public double Repairs { get; set; }

		/// <summary>
		/// Box 22, Supplies
		/// </summary>
		[JsonPropertyName("supplies")]
		public double Supplies { get; set; }

		/// <summary>
		/// Box 23, Taxes and licenses
		/// </summary>
		[JsonPropertyName("taxes")]
		public double Taxes { get; set; }

		/// <summary>
		/// Box 24a, Travel
		/// </summary>
		[JsonPropertyName("travel")]
		public double Travel { get; set; }

		/// <summary>
		/// Box 24b, Deductible meals
		/// </summary>
		[JsonPropertyName("meals")]
		public double Meals { get; set; }

		/// <summary>
		/// Box 25, Utilities
		/// </summary>
		[JsonPropertyName("utilities")]
		public double Utilities { get; set; }

		/// <summary>
		/// Box 26, Wages
		/// </summary>
		[JsonPropertyName("wages")]
		public double Wages { get; set; }

		/// <summary>
		/// Box 27, Other expenses
		/// </summary>
		[JsonPropertyName("otherExpenses")]
		public List<DescriptionAmount>? OtherExpenses { get; set; }

		/// <summary>
		/// Box 35, Inventory at beginning of year
		/// </summary>
		[JsonPropertyName("beginningInventory")]
		public double BeginningInventory { get; set; }

		/// <summary>
		/// Box 36, Purchases
		/// </summary>
		[JsonPropertyName("purchases")]
		public double Purchases { get; set; }

		/// <summary>
		/// Box 37, Cost of labor
		/// </summary>
		[JsonPropertyName("costOfLabor")]
		public double CostOfLabor { get; set; }

		/// <summary>
		/// Box 38, Materials and supplies
		/// </summary>
		[JsonPropertyName("materials")]
		public double Materials { get; set; }

		/// <summary>
		/// Box 39, Other costs
		/// </summary>
		[JsonPropertyName("otherCosts")]
		public List<DescriptionAmount>? OtherCosts { get; set; }

		/// <summary>
		/// Box 41, Inventory at end of year
		/// </summary>
		[JsonPropertyName("endingInventory")]
		public double EndingInventory { get; set; }

		/// <summary>
		/// Capital expenditures, for use in calculating Depreciation
		/// </summary>
		[JsonPropertyName("capitalExpenditures")]
		public List<DateAmount>? CapitalExpenditures { get; set; }
	}
}

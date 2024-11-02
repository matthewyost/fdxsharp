using FdxSharp.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Farm Rental Income Statement, Farm Rental Income Statement for IRS Form 4835
	/// </summary>
	public class FarmRentalIncomeStatement : Tax
	{
		/// <summary>
		/// Box 1, Income from production of livestock, produce, grains, and other crops
		/// </summary>
		[JsonPropertyName("incomeFromProduction")]
		public double IncomeFromProduction { get; set; }

		/// <summary>
		/// Box 2a, Cooperative distributions
		/// </summary>
		[JsonPropertyName("coopDistributions")]
		public double CoopDistributions { get; set; }

		/// <summary>
		/// Box 3a, Agricultural program payments
		/// </summary>
		[JsonPropertyName("agProgramPayments")]
		public double AgProgramPayments { get; set; }

		/// <summary>
		/// Box 4a, Commodity Credit Corporation (CCC) loans reported under election
		/// </summary>
		[JsonPropertyName("cccLoans")]
		public double CccLoans { get; set; }

		/// <summary>
		/// Box 5a, Crop insurance proceeds and federal crop disaster payments
		/// </summary>
		[JsonPropertyName("cropInsuranceProceeds")]
		public double CropInsuranceProceeds { get; set; }

		/// <summary>
		/// Box 6, Other income
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public List<DescriptionAmount>? OtherIncome { get; set; }

		/// <summary>
		/// Box 8, Car and truck expenses
		/// </summary>
		[JsonPropertyName("carAndTruck")]
		public double CarAndTruck { get; set; }

		/// <summary>
		/// Box 9, Chemicals
		/// </summary>
		[JsonPropertyName("chemicals")]
		public double Chemicals { get; set; }

		/// <summary>
		/// Box 10, Conservation expenses
		/// </summary>
		[JsonPropertyName("conservation")]
		public double Conservation { get; set; }

		/// <summary>
		/// Box 11, Custom hire (machine work)
		/// </summary>
		[JsonPropertyName("customHireExpenses")]
		public double CustomHireExpenses { get; set; }

		/// <summary>
		/// Box 12, Depreciation
		/// </summary>
		[JsonPropertyName("depreciation")]
		public double Depreciation { get; set; }

		/// <summary>
		/// Box 13, Employee benefit programs
		/// </summary>
		[JsonPropertyName("employeeBenefitPrograms")]
		public double EmployeeBenefitPrograms { get; set; }

		/// <summary>
		/// Box 14, Feed
		/// </summary>
		[JsonPropertyName("feed")]
		public double Feed { get; set; }

		/// <summary>
		/// Box 15, Fertilizers and lime
		/// </summary>
		[JsonPropertyName("fertilizers")]
		public double Fertilizers { get; set; }

		/// <summary>
		/// Box 16, Freight and trucking
		/// </summary>
		[JsonPropertyName("freight")]
		public double Freight { get; set; }

		/// <summary>
		/// Box 17, Gasoline, fuel, and oil
		/// </summary>
		[JsonPropertyName("fuel")]
		public double Fuel { get; set; }

		/// <summary>
		/// Box 18, Insurance (other than health)
		/// </summary>
		[JsonPropertyName("insurance")]
		public double Insurance { get; set; }

		/// <summary>
		/// Box 19a, Mortgage Interest
		/// </summary>
		[JsonPropertyName("mortgageInterest")]
		public double MortgageInterest { get; set; }

		/// <summary>
		/// Box 19b, Other interest
		/// </summary>
		[JsonPropertyName("otherInterest")]
		public double OtherInterest { get; set; }

		/// <summary>
		/// Box 20, Labor hired
		/// </summary>
		[JsonPropertyName("laborHired")]
		public double LaborHired { get; set; }

		/// <summary>
		/// Box 21, Pension and profit-sharing plans
		/// </summary>
		[JsonPropertyName("pension")]
		public double Pension { get; set; }

		/// <summary>
		/// Box 22a, Rent or lease: Vehicles, machinery, equipment
		/// </summary>
		[JsonPropertyName("equipmentRent")]
		public double EquipmentRent { get; set; }

		/// <summary>
		/// Box 22b, Rent or lease: Other
		/// </summary>
		[JsonPropertyName("otherRent")]
		public double OtherRent { get; set; }

		/// <summary>
		/// Box 23, Repairs and maintenance
		/// </summary>
		[JsonPropertyName("repairs")]
		public double Repairs { get; set; }

		/// <summary>
		/// Box 24, Seeds and plants
		/// </summary>
		[JsonPropertyName("seeds")]
		public double Seeds { get; set; }

		/// <summary>
		/// Box 25, Storage and warehousing
		/// </summary>
		[JsonPropertyName("storage")]
		public double Storage { get; set; }

		/// <summary>
		/// Box 26, Supplies
		/// </summary>
		[JsonPropertyName("supplies")]
		public double Supplies { get; set; }

		/// <summary>
		/// Box 27, Taxes
		/// </summary>
		[JsonPropertyName("taxes")]
		public double Taxes { get; set; }

		/// <summary>
		/// Box 28, Utilities
		/// </summary>
		[JsonPropertyName("utilities")]
		public double Utilities { get; set; }

		/// <summary>
		/// Box 29, Veterinary, breeding, and medicine
		/// </summary>
		[JsonPropertyName("veterinary")]
		public double Veterinary { get; set; }

		/// <summary>
		/// Box 30, Other expenses
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

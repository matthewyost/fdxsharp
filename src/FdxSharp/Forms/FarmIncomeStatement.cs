using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Farm Income Statement, Farm Income Statement for IRS Form 1040 Schedule F
	/// </summary>
	public class FarmIncomeStatement : Tax
	{
		/// <summary>
		/// Box A, Principal crop or activity
		/// </summary>
		[JsonPropertyName("cropOrActivity")]
		public string? CropOrActivity { get; set; }

		/// <summary>
		/// Box 1a, Sales of livestock and other resale items
		/// </summary>
		[JsonPropertyName("sales")]
		public double Sales { get; set; }

		/// <summary>
		/// Box 1b, Cost or other basis of livestock or other items
		/// </summary>
		[JsonPropertyName("costOfItemsSold")]
		public double CostOfItemsSold { get; set; }

		/// <summary>
		/// Box 2, Sales of livestock, produce, grains, and other products you raised
		/// </summary>
		[JsonPropertyName("salesOfRaised")]
		public double SalesOfRaised { get; set; }

		/// <summary>
		/// Box 3a, Cooperative distributions
		/// </summary>
		[JsonPropertyName("coopDistributions")]
		public double CoopDistributions { get; set; }

		/// <summary>
		/// Box 4a, Agricultural program payments
		/// </summary>
		[JsonPropertyName("agProgramPayments")]
		public double AgProgramPayments { get; set; }

		/// <summary>
		/// Box 5a, Commodity Credit Corporation (CCC) loans reported under election
		/// </summary>
		[JsonPropertyName("cccLoans")]
		public double CCCLoans { get; set; }

		/// <summary>
		/// Box 6a, Crop insurance proceeds and federal crop disaster payments
		/// </summary>
		[JsonPropertyName("cropInsuranceProceeds")]
		public double CropInsuranceProceeds { get; set; }

		/// <summary>
		/// Box 7, Custom hire (machine work) income
		/// </summary>
		[JsonPropertyName("customHireIncome")]
		public double CustomHireIncome { get; set; }

		/// <summary>
		/// Box 8, Other income
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public DescriptionAmount[]? OtherIncome { get; set; }

		/// <summary>
		/// Box 10, Car and truck expenses
		/// </summary>
		[JsonPropertyName("carAndTruck")]
		public double CarAndTruck { get; set; }

		/// <summary>
		/// Box 11, Chemicals
		/// </summary>
		[JsonPropertyName("chemicals")]
		public double Chemicals { get; set; }

		/// <summary>
		///	Box 12, Conservation expenses
		/// </summary>
		[JsonPropertyName("conservation")]
		public double Conservation { get; set; }

		/// <summary>
		/// Box 13, Custom hire (machine work)
		/// </summary>
		[JsonPropertyName("customHireExpenses")]
		public double CustomHireExpenses { get; set; }

		/// <summary>
		/// Box 14, Depreciation
		/// </summary>
		[JsonPropertyName("depreciation")]
		public double Depreciation { get; set; }

		/// <summary>
		/// Box 15, Employee benefit programs
		/// </summary>
		[JsonPropertyName("employeeBenefitPrograms")]
		public double EmployeeBenefitPrograms { get; set; }

		/// <summary>
		/// Box 16, Feed
		/// </summary>
		[JsonPropertyName("feed")]
		public double Feed { get; set; }

		/// <summary>
		/// Box 17, Fertilizers and lime
		/// </summary>
		[JsonPropertyName("fertilizers")]
		public double Fertilizers { get; set; }

		/// <summary>
		/// Box 18, Freight and trucking
		/// </summary>
		[JsonPropertyName("freight")]
		public double Freight { get; set; }

		/// <summary>
		/// Box 19, Gasoline, fuel, and oil
		/// </summary>
		[JsonPropertyName("fuel")]
		public double Fuel { get; set; }

		/// <summary>
		/// Box 20, Insurance (other than health)
		/// </summary>
		[JsonPropertyName("insurance")]
		public double Insurance { get; set; }

		/// <summary>
		/// Box 21a, Mortgage Interest
		/// </summary>
		[JsonPropertyName("mortgageInterest")]
		public double MortgageInterest { get; set; }

		/// <summary>
		/// Box 21b, Other interest
		/// </summary>
		[JsonPropertyName("otherInterest")]
		public double OtherInterest { get; set; }

		/// <summary>
		/// Box 22, Labor hired
		/// </summary>
		[JsonPropertyName("laborHired")]
		public double LaborHired { get; set; }

		/// <summary>
		/// Box 23, Pension and profit-sharing plans
		/// </summary>
		[JsonPropertyName("pension")]
		public double Pension { get; set; }

		/// <summary>
		/// Box 24a, Rent or lease: Vehicles, machinery, equipment
		/// </summary>
		[JsonPropertyName("equipmentRent")]
		public double EquipmentRent { get; set; }

		/// <summary>
		/// Box 24b, Rent or lease: Other
		/// </summary>
		[JsonPropertyName("otherRent")]
		public double OtherRent { get; set; }

		/// <summary>
		/// Box 25, Repairs and maintenance
		/// </summary>
		[JsonPropertyName("repairs")]
		public double Repairs { get; set; }

		/// <summary>
		/// Box 26, Seeds and plants
		/// </summary>
		[JsonPropertyName("seeds")]
		public double Seeds { get; set; }

		/// <summary>
		/// Box 27, Storage and warehousing
		/// </summary>
		[JsonPropertyName("storage")]
		public double Storage { get; set; }

		/// <summary>
		/// Box 28, Supplies
		/// </summary>
		[JsonPropertyName("supplies")]
		public double Supplies { get; set; }

		/// <summary>
		/// Box 29, Taxes
		/// </summary>
		[JsonPropertyName("taxes")]
		public double Taxes { get; set; }

		/// <summary>
		/// Box 30, Utilities
		/// </summary>
		[JsonPropertyName("utilities")]
		public double Utilities { get; set; }

		/// <summary>
		///	Box 31, Veterinary, breeding, and medicine
		/// </summary>
		[JsonPropertyName("veterinary")]
		public double Veterinary { get; set; }

		/// <summary>
		/// Box 32, Other expenses
		/// </summary>
		[JsonPropertyName("otherExpenses")]
		public DescriptionAmount[]? OtherExpenses { get; set; }

		/// <summary>
		/// Capital expenditures, for use in calculating Depreciation
		/// </summary>
		[JsonPropertyName("capitalExpenditures")]
		public DateAmount[]? CapitalExpenditures { get; set; }
	}
}

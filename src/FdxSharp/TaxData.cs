using FdxSharp.Forms;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp
{
	/// <summary>
	/// Tax Data, Tax data container for API requests and responses
	/// </summary>
	public class TaxData
	{
		/// <summary>
		/// Business Income Statement for IRS Form 1040 Schedule C
		/// </summary>
		[JsonPropertyName("businessIncomeStatement")]
		public BusinessIncomeStatement? BusinessIncomeStatement { get; set; }

		/// <summary>
		/// Cryptocurrency Tax Statement list
		/// </summary>
		[JsonPropertyName("cryptocurrencyTaxStatement")]
		public CryptocurrencyTaxStatement? CryptocurrencyTaxStatement { get; set; }

		/// <summary>
		/// Farm Income Statement for IRS Form 1040 Schedule F
		/// </summary>
		[JsonPropertyName("farmIncomeStatement")]
		public FarmIncomeStatement? FarmIncomeStatement { get; set; }

		/// <summary>
		/// Farm Rental Income Statement for IRS Form 4835
		/// </summary>
		[JsonPropertyName("farmRentalIncomeStatement")]
		public FarmRentalIncomeStatement? FarmRentalIncomeStatement { get; set; }

		/// <summary>
		/// Rental Income Statement for IRS Form 1040 Schedule E
		/// </summary>
		[JsonPropertyName("rentalIncomeStatement")]
		public RentalIncomeStatement? RentalIncomeStatement { get; set; }

		/// <summary>
		/// Royalty Income Statement for IRS Form 1040 Schedule E
		/// </summary>
		[JsonPropertyName("royaltyIncomeStatement")]
		public RoyaltyIncomeStatement? RoyaltyIncomeStatement { get; set; }

		/// <summary>
		/// Beneficiary's Share of Income, Deductions, Credits, etc.
		/// </summary>
		[JsonPropertyName("tax1041K1")]
		public Tax1041K1? Tax1041K1 { get; set; }

		/// <summary>
		/// Foreign Person's U.S. Source Income Subject to Withholding
		/// </summary>
		[JsonPropertyName("tax1042S")]
		public Tax1042S? Tax1042S { get; set; }

		/// <summary>
		/// Partner's Share of Income, Deductions, Credits, etc.
		/// </summary>
		[JsonPropertyName("tax1065K1")]
		public Tax1065K1? Tax1065K1 { get; set; }

		/// <summary>
		/// Health Insurance Marketplace Statement
		/// </summary>
		[JsonPropertyName("tax1095A")]
		public Tax1095A? Tax1095A { get; set; }

		/// <summary>
		/// Health Coverage
		/// </summary>
		[JsonPropertyName("tax1095B")]
		public Tax1095B? Tax1095B { get; set; }

		/// <summary>
		/// Employer-Provided Health Insurance Offer and Coverage
		/// </summary>
		[JsonPropertyName("tax1095C")]
		public Tax1095C? Tax1095C { get; set; }

		/// <summary>
		/// Bond Tax Credit
		/// </summary>
		[JsonPropertyName("tax1097Btc")]
		public Tax1097Btc? Tax1097Btc { get; set; }

		/// <summary>
		/// Mortgage Interest Statement
		/// </summary>
		[JsonPropertyName("tax1098")]
		public Tax1098? Tax1098 { get; set; }

		/// <summary>
		/// Contributions of Motor Vehicles, Boats, and Airplanes
		/// </summary>
		[JsonPropertyName("tax1098C")]
		public Tax1098C? Tax1098C { get; set; }

		/// <summary>
		/// Student Loan Interest Statement
		/// </summary>
		[JsonPropertyName("tax1098E")]
		public Tax1098E? Tax1098E { get; set; }

		/// <summary>
		/// Mortgage Assistance Payments
		/// </summary>
		[JsonPropertyName("tax1098Ma")]
		public Tax1098Ma? Tax1098Ma { get; set; }

		/// <summary>
		/// Qualifying Longevity Annuity Contract Information
		/// </summary>
		[JsonPropertyName("tax1098Q")]
		public Tax1098Q? Tax1098Q { get; set; }

		/// <summary>
		/// Tuition Statement
		/// </summary>
		[JsonPropertyName("tax1098T")]
		public Tax1098T? Tax1098T { get; set; }

		/// <summary>
		/// Acquisition or Abandonment of Secured Property
		/// </summary>
		[JsonPropertyName("tax1099A")]
		public Tax1099A? Tax1099A { get; set; }

		/// <summary>
		/// Proceeds From Broker and Barter Exchange Transactions
		/// </summary>
		[JsonPropertyName("tax1099B")]
		public Tax1099B? Tax1099B { get; set; }

		/// <summary>
		/// Cancellation of Debt
		/// </summary>
		[JsonPropertyName("tax1099C")]
		public Tax1099C? Tax1099C { get; set; }

		/// <summary>
		/// Changes in Corporate Control and Capital Structure
		/// </summary>
		[JsonPropertyName("tax1099Cap")]
		public Tax1099Cap? Tax1099Cap { get; set; }

		/// <summary>
		/// Consolidated Statement for combined IRS Form 1099s
		/// </summary>
		[JsonPropertyName("tax1099ConsolidatedStatement")]
		public Tax1099ConsolidatedStatement? Tax1099ConsolidatedStatement { get; set; }

		/// <summary>
		/// Dividends and Distributions
		/// </summary>
		[JsonPropertyName("tax1099Div")]
		public Tax1099Div? Tax1099Div { get; set; }

		/// <summary>
		/// Certain Government Payments
		/// </summary>
		[JsonPropertyName("tax1099G")]
		public Tax1099G? Tax1099G { get; set; }

		/// <summary>
		/// Health Coverage Tax Credit (HCTC) Advance Payments
		/// </summary>
		[JsonPropertyName("tax1099H")]
		public Tax1099H? Tax1099H { get; set; }

		/// <summary>
		/// Interest Income
		/// </summary>
		[JsonPropertyName("tax1099Int")]
		public Tax1099Int? Tax1099Int { get; set; }

		/// <summary>
		/// Merchant Card and Third-Party Network Payments
		/// </summary>
		[JsonPropertyName("tax1099K")]
		public Tax1099K? Tax1099K { get; set; }

		/// <summary>
		/// Reportable Life Insurance Sale
		/// </summary>
		[JsonPropertyName("tax1099Ls")]
		public Tax1099Ls? Tax1099Ls { get; set; }

		/// <summary>
		/// Long-Term Care and Accelerated Death Benefits
		/// </summary>
		[JsonPropertyName("tax1099Ltc")]
		public Tax1099Ltc? Tax1099Ltc { get; set; }

		/// <summary>
		/// Miscellaneous Income
		/// </summary>
		[JsonPropertyName("tax1099Misc")]
		public Tax1099Misc? Tax1099Misc { get; set; }

		/// <summary>
		/// Nonemployee Compensation
		/// </summary>
		[JsonPropertyName("tax1099Nec")]
		public Tax1099Nec? Tax1099Nec { get; set; }

		/// <summary>
		/// Original Issue Discount
		/// </summary>
		[JsonPropertyName("tax1099Oid")]
		public Tax1099Oid? Tax1099Oid { get; set; }

		/// <summary>
		/// Taxable Distributions Received From Cooperatives
		/// </summary>
		[JsonPropertyName("tax1099Patr")]
		public Tax1099Patr? Tax1099Patr { get; set; }

		/// <summary>
		/// Payments From Qualified Education Programs
		/// </summary>
		[JsonPropertyName("tax1099Q")]
		public Tax1099Q? Tax1099Q { get; set; }

		/// <summary>
		/// Distributions From ABLE Accounts
		/// </summary>
		[JsonPropertyName("tax1099Qa")]
		public Tax1099Qa? Tax1099Qa { get; set; }

		/// <summary>
		/// Distributions from Pensions, Annuities, Retirement or Profit-Sharing Plans, IRAs, Insurance Contracts, etc.
		/// </summary>
		[JsonPropertyName("tax1099R")]
		public Tax1099R? Tax1099R { get; set; }

		/// <summary>
		/// Proceeds From Real Estate Transactions
		/// </summary>
		[JsonPropertyName("tax1099S")]
		public Tax1099S? Tax1099S { get; set; }

		/// <summary>
		/// Distributions From an HSA, Archer MSA, or Medicare Advantage MSA
		/// </summary>
		[JsonPropertyName("tax1099Sa")]
		public Tax1099Sa? Tax1099Sa { get; set; }

		/// <summary>
		/// Seller's Investment in Life Insurance Contract
		/// </summary>
		[JsonPropertyName("tax1099Sb")]
		public Tax1099Sb? Tax1099Sb { get; set; }

		/// <summary>
		/// Shareholder's Share of Income, Deductions, Credits, etc.
		/// </summary>
		[JsonPropertyName("tax1120SK1")]
		public Tax1120SK1? Tax1120SK1 { get; set; }

		/// <summary>
		/// Notice to Shareholder of Undistributed Long-Term Capital Gains
		/// </summary>
		[JsonPropertyName("tax2439")]
		public Tax2439? Tax2439 { get; set; }

		/// <summary>
		/// Exercise of an Incentive Stock Option Under Section 422(b)
		/// </summary>
		[JsonPropertyName("tax3921")]
		public Tax3921? Tax3921 { get; set; }

		/// <summary>
		/// Transfer of Stock Acquired Through an Employee Stock Purchase Plan under Section 423(c)
		/// </summary>
		[JsonPropertyName("tax3922")]
		public Tax3922? Tax3922 { get; set; }

		/// <summary>
		/// Split-Interest Trust Beneficiary's schedule K-1
		/// </summary>
		[JsonPropertyName("tax5227K1")]
		public Tax5227K1? Tax5227K1 { get; set; }

		/// <summary>
		/// IRA Contribution Information
		/// </summary>
		[JsonPropertyName("tax5498")]
		public Tax5498? Tax5498 { get; set; }

		/// <summary>
		/// Coverdell ESA Contribution Information
		/// </summary>
		[JsonPropertyName("tax5498Esa")]
		public Tax5498Esa? Tax5498Esa { get; set; }

		/// <summary>
		/// ABLE Account Contribution Information
		/// </summary>
		[JsonPropertyName("tax5498Qa")]
		public Tax5498Qa? Tax5498Qa { get; set; }

		/// <summary>
		/// HSA, Archer MSA, or Medicare Advantage MSA Information
		/// </summary>
		[JsonPropertyName("tax5498Sa")]
		public Tax5498Sa? Tax5498Sa { get; set; }

		/// <summary>
		/// Wage and Tax Statement
		/// </summary>
		[JsonPropertyName("taxW2")]
		public TaxW2? TaxW2 { get; set; }

		/// <summary>
		/// IRS form W-2c, Corrected Wage and Tax Statement
		/// </summary>
		[JsonPropertyName("taxW2C")]
		public TaxW2C? TaxW2C { get; set; }

		/// <summary>
		/// Certain Gambling Winnings
		/// </summary>
		[JsonPropertyName("taxW2G")]
		public TaxW2G? TaxW2G { get; set; }

		/// <summary>
		/// Tax refund direct deposit information
		/// </summary>
		[JsonPropertyName("taxRefundDirectDeposit")]
		public TaxRefundDirectDeposit? TaxRefundDirectDeposit { get; set; }
	}
}

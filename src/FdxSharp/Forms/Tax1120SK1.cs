using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1120-S K-1, Shareholder's Share of Income, Deductions, Credits, etc.
	/// </summary>
	public class Tax1120SK1 : Tax
	{
		/// <summary>
		/// Final K-1
		/// </summary>
		[JsonPropertyName("finalK1")]
		public bool FinalK1 { get; set; }

		/// <summary>
		/// Amended K-1
		/// </summary>
		[JsonPropertyName("amendedK1")]
		public bool AmendedK1 { get; set; }

		/// <summary>
		/// Fiscal year begin date
		/// </summary>
		[JsonPropertyName("fiscalYearBegin")]
		public DateTime? FiscalYearBegin { get; set; }

		/// <summary>
		/// Fiscal year end date
		/// </summary>
		[JsonPropertyName("fiscalYearEnd")]
		public DateTime? FiscalYearEnd { get; set; }

		/// <summary>
		/// Box A, Corporation's employer identification number
		/// </summary>
		[JsonPropertyName("corporationTin")]
		public string? CorporationTin { get; set; }

		/// <summary>
		/// Box B, Corporation's name, address, city, state, and ZIP code
		/// </summary>
		[JsonPropertyName("corporationNameAddress")]
		public NameAddress? CorporationNameAddress { get; set; }

		/// <summary>
		/// Box C, IRS Center where corporation filed return
		/// </summary>
		[JsonPropertyName("irsCenter")]
		public string? IrsCenter { get; set; }

		/// <summary>
		/// Box D, Corporation's total number of shares, Beginning of tax year
		/// </summary>
		[JsonPropertyName("corporationBeginningShares")]
		public double CorporationBeginningShares { get; set; }

		/// <summary>
		/// Box D, Corporation's total number of shares, End of tax year
		/// </summary>
		[JsonPropertyName("corporationEndingShares")]
		public double CorporationEndingShares { get; set; }

		/// <summary>
		/// Box E, Shareholder's identifying number
		/// </summary>
		[JsonPropertyName("shareholderTin")]
		public string? ShareholderTin { get; set; }

		/// <summary>
		/// Box F, Shareholder's name, address, city, state, and ZIP code
		/// </summary>
		[JsonPropertyName("shareholderNameAddress")]
		public NameAddress? ShareholderNameAddress { get; set; }

		/// <summary>
		/// Box G, Current year allocation percentage
		/// </summary>
		[JsonPropertyName("percentOwnership")]
		public double PercentOwnership { get; set; }

		/// <summary>
		/// Box H, Shareholder's number of shares, Beginning of tax year
		/// </summary>
		[JsonPropertyName("beginningShares")]
		public double BeginningShares { get; set; }

		/// <summary>
		/// Box H, Shareholder's number of shares, End of tax year
		/// </summary>
		[JsonPropertyName("endingShares")]
		public double EndingShares { get; set; }

		/// <summary>
		/// Box I, Loans from shareholder, Beginning of tax year
		/// </summary>
		[JsonPropertyName("beginningLoans")]
		public double BeginningLoans { get; set; }

		/// <summary>
		/// Box I, Loans from shareholder, Ending of tax year
		/// </summary>
		[JsonPropertyName("endingLoans")]
		public double EndingLoans { get; set; }

		/// <summary>
		/// Box 1, Ordinary business income (loss)
		/// </summary>
		[JsonPropertyName("ordinaryIncome")]
		public double OrdinaryIncome { get; set; }

		/// <summary>
		/// Box 2, Net rental real estate income (loss)
		/// </summary>
		[JsonPropertyName("netRentalRealEstateIncome")]
		public double NetRentalRealEstateIncome { get; set; }

		/// <summary>
		/// Box 3, Other net rental income (loss)
		/// </summary>
		[JsonPropertyName("otherRentalIncome")]
		public double OtherRentalIncome { get; set; }

		/// <summary>
		/// Box 4, Interest income
		/// </summary>
		[JsonPropertyName("interestIncome")]
		public double InterestIncome { get; set; }

		/// <summary>
		/// Box 5a, Ordinary dividends
		/// </summary>
		[JsonPropertyName("ordinaryDividends")]
		public double OrdinaryDividends { get; set; }

		/// <summary>
		/// Box 5b, Qualified dividends
		/// </summary>
		[JsonPropertyName("qualifiedDividends")]
		public double QualifiedDividends { get; set; }

		/// <summary>
		/// Box 6, Royalties
		/// </summary>
		[JsonPropertyName("royalties")]
		public double Royalties { get; set; }

		/// <summary>
		/// Box 7, Net short-term capital gain (loss)
		/// </summary>
		[JsonPropertyName("netShortTermGain")]
		public double NetShortTermGain { get; set; }

		/// <summary>
		/// Box 8a, Net long-term capital gain (loss)
		/// </summary>
		[JsonPropertyName("netLongTermGain")]
		public double NetLongTermGain { get; set; }

		/// <summary>
		/// Box 8b, Collectibles (28%) gain (loss)
		/// </summary>
		[JsonPropertyName("collectiblesGain")]
		public double CollectiblesGain { get; set; }

		/// <summary>
		/// Box 8c, Unrecaptured section 1250 gain
		/// </summary>
		[JsonPropertyName("unrecaptured1250Gain")]
		public double Unrecaptured1250Gain { get; set; }

		/// <summary>
		/// Box 9, Net section 1231 gain (loss)
		/// </summary>
		[JsonPropertyName("net1231Gain")]
		public double Net1231Gain { get; set; }

		/// <summary>
		/// Box 10, Other income (loss)
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public CodeAmount[]? OtherIncome { get; set; }

		/// <summary>
		/// Box 11, Section 179 deduction
		/// </summary>
		[JsonPropertyName("section179Deduction")]
		public double Section179Deduction { get; set; }

		/// <summary>
		/// Box 12, Other deductions
		/// </summary>
		[JsonPropertyName("otherDeductions")]
		public CodeAmount[]? OtherDeductions { get; set; }

		/// <summary>
		/// Box 13, Credits
		/// </summary>
		[JsonPropertyName("credits")]
		public CodeAmount[]? Credits { get; set; }

		/// <summary>
		/// Box 14, Schedule K-3 is attached
		/// </summary>
		[JsonPropertyName("scheduleK3")]
		public bool ScheduleK3 { get; set; }

		/// <summary>
		/// Box 14, Foreign transactions. IRS deprecated 2021 and is now reported on Schedule K-3
		/// </summary>
		[JsonPropertyName("foreignTransactions")]
		public CodeAmount[]? ForeignTransactions { get; set; }

		/// <summary>
		/// Box 14, Foreign country. IRS deprecated 2021 and is now reported on Schedule K-3
		/// </summary>
		[JsonPropertyName("foreignCountry")]
		public string? ForeignCountry { get; set; }

		/// <summary>
		/// Box 15, Alternative minimum tax (AMT) items
		/// </summary>
		[JsonPropertyName("amtItems")]
		public CodeAmount[]? AmtItems { get; set; }

		/// <summary>
		/// Box 16, Items affecting shareholder basis
		/// </summary>
		[JsonPropertyName("basisItems")]
		public CodeAmount[]? BasisItems { get; set; }

		/// <summary>
		/// Box 17, Other information
		/// </summary>
		[JsonPropertyName("otherInfo")]
		public CodeAmount[]? OtherInfo { get; set; }

		/// <summary>
		/// Box 18, More than one activity for at-risk purposes
		/// </summary>
		[JsonPropertyName("multipleAtRiskActivities")]
		public bool MultipleAtRiskActivities { get; set; }

		/// <summary>
		/// Box 19, More than one activity for passive activity purposes
		/// </summary>
		[JsonPropertyName("multiplePassiveActivities")]
		public bool MultiplePassiveActivities { get; set; }
	}
}

using FdxSharp.Models;
using System;
using System.Collections.Generic;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1041 K-1, Beneficiary's Share of Income, Deductions, Credits, etc.
	/// </summary>
	public class Tax1041K1 : Tax
	{
		/// <summary>
		/// Final K-1.
		/// </summary>
		public bool FinalK1 { get; set; }

		/// <summary>
		/// Amended K-1.
		/// </summary>
		public bool AmendedK1 { get; set; }

		/// <summary>
		/// Fiscal year begin date.
		/// </summary>
		public DateTime FiscalYearBegin { get; set; }

		/// <summary>
		/// Fiscal year end date.
		/// </summary>
		public DateTime FiscalYearEnd { get; set; }

		/// <summary>
		/// Box A, Estate's or trust's employer identification number.
		/// </summary>
		public string? TrustTin { get; set; }

		/// <summary>
		/// Box B, Estate's or trust's name.
		/// </summary>
		public string? TrustName { get; set; }

		/// <summary>
		/// Box D, Check if Form 1041-T was filed.
		/// </summary>
		public bool Form1041T { get; set; }

		/// <summary>
		/// Box D, and enter the date it was filed.
		/// </summary>
		public DateTime Date1041T { get; set; }

		/// <summary>
		/// Box E, Check if this is the final Form 1041 for the estate or trust.
		/// </summary>
		public bool Final1041 { get; set; }

		/// <summary>
		/// Box F, Beneficiary's identifying number.
		/// </summary>
		public string BeneficiaryTin { get; set; }

		/// <summary>
		/// Box H, Domestic beneficiary.
		/// </summary>
		public bool Domestic { get; set; }

		/// <summary>
		/// Box H, Foreign beneficiary.
		/// </summary>
		public bool Foreign { get; set; }

		/// <summary>
		/// Box 1, Interest income.
		/// </summary>
		public double InterestIncome { get; set; }

		/// <summary>
		/// Box 2a, Ordinary dividends.
		/// </summary>
		public double OrdinaryDividends { get; set; }

		/// <summary>
		/// Box 2b, Qualified dividends.
		/// </summary>
		public double QualifiedDividends { get; set; }

		/// <summary>
		/// Box 3, Net short-term capital gain.
		/// </summary>
		public double NetShortTermGain { get; set; }

		/// <summary>
		/// Box 4a, Net long-term capital gain.
		/// </summary>
		public double NetLongTermGain { get; set; }

		/// <summary>
		/// Box 4b, 28% rate gain.
		/// </summary>
		public double Gain28Rate { get; set; }

		/// <summary>
		/// Box 4c, Unrecaptured section 1250 gain.
		/// </summary>
		public double Unrecaptured1250Gain { get; set; }

		/// <summary>
		/// Box 5, Other portfolio and nonbusiness income.
		/// </summary>
		public double OtherPortfolioIncome { get; set; }

		/// <summary>
		/// Box 6, Ordinary business income.
		/// </summary>
		public double OrdinaryBusinessIncome { get; set; }

		/// <summary>
		/// Box 7, Net rental real estate income.
		/// </summary>
		public double NetRentalRealEstateIncome { get; set; }

		/// <summary>
		/// Box 8, Other rental income.
		/// </summary>
		public double OtherRentalIncome { get; set; }

		/// <summary>
		/// Box 9, Directly apportioned deductions.
		/// </summary>
		public List<CodeAmount>? DirectlyApportionedDeductions { get; set; }

		/// <summary>
		/// Box 10, Estate tax deduction.
		/// </summary>
		public double EstateTaxDeduction { get; set; }

		/// <summary>
		/// Box 11, Final year deductions.
		/// </summary>
		public List<CodeAmount>? FinalYearDeductions { get; set; }

		/// <summary>
		/// Box C, Fiduciary's name and address.
		/// </summary>
		public NameAddress? FiduciaryNameAddress { get; set; }

		/// <summary>
		/// Box 12, Alternative minimum tax adjustment.
		/// </summary>
		public List<CodeAmount>? AmtAdjustments { get; set; }

		/// <summary>
		/// Box G, Beneficiary's name and address.
		/// </summary>
		public NameAddress? BeneficiaryNameAddress { get; set; }

		/// <summary>
		/// Box 13, Credits and credit recapture.
		/// </summary>
		public List<CodeAmount>? Credits { get; set; }

		/// <summary>
		/// Box 14, Other information.
		/// </summary>
		public List<CodeAmount>? OtherInfo { get; set; }
	}
}

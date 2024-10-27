using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099 Consolidated Statement, Various tax-related items reported on 
	/// consolidated brokerage or mutual fund statements not on the base 1099 forms. 
	/// The component 1099 forms are delivered as their own Tax1099Xxx entities as usual
	/// </summary>
	public class Tax1099ConsolidatedStatement : Tax
	{
		/// <summary>
		/// Interest paid on margin account
		/// </summary>
		[JsonPropertyName("marginInterestPaid")]
		public double MarginInterestPaid { get; set; }

		/// <summary>
		/// Payment in lieu of dividends paid
		/// </summary>
		[JsonPropertyName("paymentInLieuPaid")]
		public double PaymentInLieuPaid { get; set; }

		/// <summary>
		/// Advisor fees paid
		/// </summary>
		[JsonPropertyName("advisorFeesPaid")]
		public double AdvisorFeesPaid { get; set; }

		/// <summary>
		/// Other fees paid
		/// </summary>
		[JsonPropertyName("otherFeesPaid")]
		public double OtherFeesPaid { get; set; }

		/// <summary>
		/// Accrued Interest Paid offset to form 1099-INT box 1, Corporate bond interest income
		/// </summary>
		[JsonPropertyName("corporateBondInterestPaid")]
		public double CorporateBondInterestPaid { get; set; }

		/// <summary>
		/// Accrued Interest Paid offset to form 1099-INT box 3, accrued U.S. Treasury Notes and Bonds interest income
		/// </summary>
		[JsonPropertyName("usBondInterestPaid")]
		public double UsBondInterestPaid { get; set; }

		/// <summary>
		/// Accrued Interest Paid offset to form 1099-INT box 8, tax exempt interest income from municipal bonds
		/// </summary>
		[JsonPropertyName("taxExemptInterestPaid")]
		public double TaxExemptInterestPaid { get; set; }

		/// <summary>
		/// Accrued Interest Paid offset to form 1099-INT box 9, tax exempt interest income from Private Activity Bonds
		/// </summary>
		[JsonPropertyName("specifiedPabInterestPaid")]
		public double SpecifiedPabInterestPaid { get; set; }
	}
}

using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 2439, Notice to Shareholder of Undistributed Long-Term Capital Gains
	/// </summary>
	public class Tax2439 : Tax
	{
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
		/// RIC or REIT's name, address and phone
		/// </summary>
		[JsonPropertyName("ricOrReitNameAddress")]
		public NameAddressPhone? RicOrReitNameAddress { get; set; }

		/// <summary>
		/// Identification number of RIC or REIT
		/// </summary>
		[JsonPropertyName("ricOrReitTin")]
		public string? RicOrReitTin { get; set; }

		/// <summary>
		/// Shareholder's address
		/// </summary>
		[JsonPropertyName("shareholderNameAddress")]
		public NameAddress? ShareholderNameAddress { get; set; }

		/// <summary>
		/// Shareholder's identifying number
		/// </summary>
		[JsonPropertyName("shareholderTin")]
		public string? ShareholderTin { get; set; }

		/// <summary>
		/// Box 1a, Total undistributed long-term capital gains
		/// </summary>
		[JsonPropertyName("undistributedLongTermCapitalGains")]
		public double UndistributedLongTermCapitalGains { get; set; }

		/// <summary>
		/// Box 1b, Unrecaptured section 1250 gain
		/// </summary>
		[JsonPropertyName("unrecaptured1250Gain")]
		public double Unrecaptured1250Gain { get; set; }

		/// <summary>
		/// Box 1c, Section 1202 gain
		/// </summary>
		[JsonPropertyName("section1202Gain")]
		public double Section1202Gain { get; set; }

		/// <summary>
		/// Box 1d, Collectibles (28%) gain
		/// </summary>
		[JsonPropertyName("collectiblesGain")]
		public double CollectiblesGain { get; set; }

		/// <summary>
		/// Box 2, Tax paid by the RIC or REIT on the box 1a gains
		/// </summary>
		[JsonPropertyName("taxPaid")]
		public double TaxPaid { get; set; }
	}
}

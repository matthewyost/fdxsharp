using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Security Detail, IRS Form 1099-B, Tax information for a single security transaction
	/// </summary>
	public class SecurityDetail
	{
		/// <summary>
		/// Applicable checkbox on Form 8949
		/// </summary>
		[JsonPropertyName("checkboxOnForm8949")]
		public string? CheckboxOnForm8949 { get; set; }

		/// <summary>
		/// Security name
		/// </summary>
		[JsonPropertyName("securityName")]
		public string? SecurityName { get; set; }

		/// <summary>
		/// Number of shares
		/// </summary>
		[JsonPropertyName("numberOfShares")]
		public double NumberOfShares { get; set; }

		/// <summary>
		/// Box 1a, Description of property
		/// </summary>
		[JsonPropertyName("saleDescription")]
		public string? SaleDescription { get; set; }

		/// <summary>
		/// Box 1b, Date acquired
		/// </summary>
		[JsonPropertyName("dateAcquired")]
		public DateTime DateAcquired { get; set; }

		/// <summary>
		/// Box 1b, Date acquired Various
		/// </summary>
		[JsonPropertyName("variousDatesAcquired")]
		public bool VariousDatesAcquired { get; set; }

		/// <summary>
		/// Box 1c, Date sold or disposed
		/// </summary>
		[JsonPropertyName("dateOfSale")]
		public DateTime DateOfSale { get; set; }

		/// <summary>
		/// Box 1d, Proceeds (not price per share)
		/// </summary>
		[JsonPropertyName("salesPrice")]
		public double SalesPrice { get; set; }

		/// <summary>
		/// Box 1f, Accrued market discount
		/// </summary>
		[JsonPropertyName("accruedMarketDiscount")]
		public double AccruedMarketDiscount { get; set; }

		/// <summary>
		/// Other adjustments (code and amount)
		/// </summary>
		[JsonPropertyName("adjustmentCodes")]
		public CodeAmount[]? AdjustmentCodes { get; set; }

		/// <summary>
		/// Box 1e, Cost or other basis
		/// </summary>
		[JsonPropertyName("costBasis")]
		public double CostBasis { get; set; }

		/// <summary>
		/// Corrected cost basis. May be supplied in lieu of adjustmentCode code B. If both adjustmentCodes and correctedCostBasis are supplied, costBasis plus adjustmentCode B should equal correctedCostBasis
		/// </summary>
		[JsonPropertyName("correctedCostBasis")]
		public double CorrectedCostBasis { get; set; }

		/// <summary>
		/// Box 1g, Wash sale loss disallowed
		/// </summary>
		[JsonPropertyName("washSaleLossDisallowed")]
		public double WashSaleLossDisallowed { get; set; }

		/// <summary>
		/// Box 2, LONG or SHORT
		/// </summary>
		[JsonPropertyName("longOrShort")]
		public SalesTermType LongOrShort { get; set; }

		/// <summary>
		/// Box 2, Ordinary
		/// </summary>
		[JsonPropertyName("ordinary")]
		public bool Ordinary { get; set; }

		/// <summary>
		/// Box 3, Collectibles
		/// </summary>
		[JsonPropertyName("collectible")]
		public bool Collectible { get; set; }

		/// <summary>
		/// Box 3, Qualified Opportunity Fund (QOF)
		/// </summary>
		[JsonPropertyName("qof")]
		public bool Qof { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Noncovered security
		/// </summary>
		[JsonPropertyName("noncoveredSecurity")]
		public bool NoncoveredSecurity { get; set; }

		/// <summary>
		/// Box 6, Reported to IRS: GROSS or NET
		/// </summary>
		[JsonPropertyName("grossOrNet")]
		public SaleProceedsType GrossOrNet { get; set; }

		/// <summary>
		/// Box 7, Loss not allowed based on proceeds
		/// </summary>
		[JsonPropertyName("lossNotAllowed")]
		public bool LossNotAllowed { get; set; }

		/// <summary>
		/// Box 12, Basis reported to IRS
		/// </summary>
		[JsonPropertyName("basisReported")]
		public bool BasisReported { get; set; }

		/// <summary>
		/// Boxes 14-16, State withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// CUSIP number
		/// </summary>
		[JsonPropertyName("cusip")]
		public string? Cusip { get; set; }

		/// <summary>
		/// Foreign account tax compliance
		/// </summary>
		[JsonPropertyName("foreignAccountTaxCompliance")]
		public bool ForeignAccountTaxCompliance { get; set; }

		/// <summary>
		/// To indicate gain or loss resulted from option expiration. If salesPrice (1d, proceeds) is zero, use PURCHASED. If costBasis (1e) is zero, use GRANTED
		/// </summary>
		[JsonPropertyName("expiredOption")]
		public ExpiredOptionType ExpiredOption { get; set; }

		/// <summary>
		/// Type of investment sale
		/// </summary>
		[JsonPropertyName("investmentSaleType")]
		public InvestmentSaleType InvestmentSaleType { get; set; }
	}
}

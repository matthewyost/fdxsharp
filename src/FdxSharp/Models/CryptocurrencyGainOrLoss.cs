using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Cryptocurrency Gain or Loss entity, A single cryptocurrency gain or loss
	/// </summary>
	public class CryptocurrencyGainOrLoss
	{
		/// <summary>
		/// Gets or sets Cryptocurrency Name.
		/// </summary>
		[JsonPropertyName("cryptocurrencyName")]
		public string? CryptocurrencyName { get; set; }

		/// <summary>
		/// Gets or sets Cryptocurrency Symbol.
		/// </summary>
		[JsonPropertyName("symbol")]
		public string? Symbol { get; set; }

		/// <summary>
		/// Gets or sets Cryptocurrency Quantity.
		/// </summary>
		[JsonPropertyName("quantity")]
		public double Quantity { get; set; }

		/// <summary>
		/// Gets or sets Sale Description.
		/// </summary>
		[JsonPropertyName("saleDescription")]
		public string? SaleDescription { get; set; }

		/// <summary>
		/// Gets or sets Date Acquired.
		/// </summary>
		[JsonPropertyName("dateAcquired")]
		public DateOnly DateAcquired { get; set; }

		/// <summary>
		/// Gets or sets Various Dates Acquired.
		/// </summary>
		[JsonPropertyName("variousDatesAcquired")]
		public bool VariousDatesAcquired { get; set; }

		/// <summary>
		/// Gets or sets Date of Sale.
		/// </summary>
		[JsonPropertyName("dateOfSale")]
		public DateOnly DateOfSale { get; set; }

		/// <summary>
		/// Gets or sets Sales Price.
		/// </summary>
		[JsonPropertyName("salesPrice")]
		public double SalesPrice { get; set; }

		/// <summary>
		/// Gets or sets Cost Basis.
		/// </summary>
		[JsonPropertyName("costBasis")]
		public double CostBasis { get; set; }

		/// <summary>
		/// Gets or sets Long or Short.
		/// </summary>
		[JsonPropertyName("longOrShort")]
		public SalesTermType LongOrShort { get; set; }
	}
}

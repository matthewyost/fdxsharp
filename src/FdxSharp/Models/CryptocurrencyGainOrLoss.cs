using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	public class CryptocurrencyGainOrLoss
	{
		[JsonPropertyName("cryptocurrencyName")]
		public string? CryptocurrencyName { get; set; }

		[JsonPropertyName("symbol")]
		public string? Symbol { get; set; }

		[JsonPropertyName("quantity")]
		public double Quantity { get; set; }

		[JsonPropertyName("saleDescription")]
		public string? SaleDescription { get; set; }

		[JsonPropertyName("dateAcquired")]
		public DateOnly DateAcquired { get; set; }

		[JsonPropertyName("variousDatesAcquired")]
		public bool VariousDatesAcquired { get; set; }

		[JsonPropertyName("dateOfSale")]
		public DateOnly DateOfSale { get; set; }

		[JsonPropertyName("salesPrice")]
		public double SalesPrice { get; set; }

		[JsonPropertyName("costBasis")]
		public double CostBasis { get; set; }

		[JsonPropertyName("longOrShort")]
		public SalesTermType LongOrShort { get; set; }
	}
}

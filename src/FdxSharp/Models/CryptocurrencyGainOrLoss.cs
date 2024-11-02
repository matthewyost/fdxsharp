using FdxSharp.Enums;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Cryptocurrency gain or loss entity, Details of cryptocurrency gain or loss.
	/// </summary>
	public class CryptocurrencyGainOrLoss
	{
		/// <summary>
		/// Cryptocurrency name (e.g. Bitcoin)
		/// </summary>
		[JsonPropertyName("cryptocurrencyName")]
		public string? CryptocurrencyName { get; set; }

		/// <summary>
		/// Cryptocurrency abbreviation or symbol (e.g. BTC)
		/// </summary>
		[JsonPropertyName("symbol")]
		public string? Symbol { get; set; }

		/// <summary>
		/// Quantity (e.g. 0.0125662)
		/// </summary>
		[JsonPropertyName("quantity")]
		public double Quantity { get; set; }

		/// <summary>
		/// Description of property (1099-B box 1a)
		/// </summary>
		[JsonPropertyName("saleDescription")]
		public string? SaleDescription { get; set; }

		/// <summary>
		/// Date acquired (1099-B box 1b)
		/// </summary>
		[JsonPropertyName("dateAcquired")]
		public DateTime DateAcquired { get; set; }

		/// <summary>
		/// Acquired on various dates (1099-B box 1b)
		/// </summary>
		[JsonPropertyName("variousDatesAcquired")]
		public bool VariousDatesAcquired { get; set; }

		/// <summary>
		/// Date sold or disposed (1099-B box 1c)
		/// </summary>
		[JsonPropertyName("dateOfSale")]
		public DateTime? DateOfSale { get; set; }

		/// <summary>
		/// Proceeds (not price per share, 1099-B box 1d)
		/// </summary>
		[JsonPropertyName("salesPrice")]
		public double SalesPrice { get; set; }

		/// <summary>
		/// Cost or other basis (1099-B box 1e)
		/// </summary>
		[JsonPropertyName("costBasis")]
		public double CostBasis { get; set; }

		/// <summary>
		/// LONG or SHORT (1099-B box 2)
		/// </summary>
		[JsonPropertyName("longOrShort")]
		public SalesTermType LongOrShort { get; set; }
	}
}

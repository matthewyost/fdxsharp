using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-CAP, Changes in Corporate Control and Capital Structure
	/// </summary>
	public class Tax1099Cap : Tax
	{
		/// <summary>
		/// Corporation's name, address, and phone
		/// </summary>
		[JsonPropertyName("corporationNameAddress")]
		public NameAddressPhone? CorporationNameAddress { get; set; }

		/// <summary>
		/// CORPORATION'S TIN
		/// </summary>
		[JsonPropertyName("corporationTin")]
		public string? CorporationTin { get; set; }

		/// <summary>
		/// SHAREHOLDER'S TIN
		/// </summary>
		[JsonPropertyName("shareholderTin")]
		public string? ShareholderTin { get; set; }

		/// <summary>
		/// Shareholder's name and address
		/// </summary>
		[JsonPropertyName("shareholderNameAddress")]
		public NameAddress? ShareholderNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Date of sale or exchange
		/// </summary>
		[JsonPropertyName("dateOfSale")]
		public DateTime? DateOfSale { get; set; }

		/// <summary>
		/// Box 2, Aggregate amount received
		/// </summary>
		[JsonPropertyName("aggregateAmount")]
		public double AggregateAmount { get; set; }

		/// <summary>
		/// Box 3, Number of shares exchanged
		/// </summary>
		[JsonPropertyName("numberOfShares")]
		public double NumberOfShares { get; set; }

		/// <summary>
		/// Box 4, Classes of stock exchanged
		/// </summary>
		[JsonPropertyName("stockClasses")]
		public string? StockClasses { get; set; }
	}
}

using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents a financial transaction.
	/// </summary>
	public class Transaction
	{
		/// <summary>
		/// Gets or sets the transaction identifier.
		/// </summary>
		[JsonPropertyName("transactionId")]
		public string TransactionId { get; set; }

		/// <summary>
		/// Gets or sets the description of the transaction.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or sets the amount of the transaction.
		/// </summary>
		[JsonPropertyName("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// Gets or sets the currency of the transaction.
		/// </summary>
		[JsonPropertyName("currency")]
		public string? Currency { get; set; }

		/// <summary>
		/// Gets or sets the date of the transaction.
		/// </summary>
		[JsonPropertyName("transactionDate")]
		public string TransactionDate { get; set; }
	}
}

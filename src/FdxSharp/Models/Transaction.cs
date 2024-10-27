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
		public string TransactionId { get; set; }

		/// <summary>
		/// Gets or sets the description of the transaction.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the amount of the transaction.
		/// </summary>
		public decimal Amount { get; set; }

		/// <summary>
		/// Gets or sets the currency of the transaction.
		/// </summary>
		public string Currency { get; set; }

		/// <summary>
		/// Gets or sets the date of the transaction.
		/// </summary>
		public string TransactionDate { get; set; }
	}
}

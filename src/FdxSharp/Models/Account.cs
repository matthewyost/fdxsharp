namespace FdxSharp.Models
{
	/// <summary>
	/// Represents an account associated with the account holder.
	/// </summary>
	public class Account
	{
		/// <summary>
		/// Gets or sets the account identifier.
		/// </summary>
		[JsonPropertyName("accountId")]
		public string AccountId { get; set; }

		/// <summary>
		/// Gets or sets the type of account.
		/// </summary>
		[JsonPropertyName("accountType")]
		public string AccountType { get; set; }

		/// <summary>
		/// Gets or sets the name of the account.
		/// </summary>
		[JsonPropertyName("accountName")]
		public string AccountName { get; set; }

		/// <summary>
		/// Gets or sets the balance of the account.
		/// </summary>
		[JsonPropertyName("balance")]
		public decimal Balance { get; set; }
	}
}

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
		[JsonProperty("accountId")]
		public string AccountId { get; set; }

		/// <summary>
		/// Gets or sets the type of account.
		/// </summary>
		[JsonProperty("accountType")]
		public string AccountType { get; set; }

		/// <summary>
		/// Gets or sets the name of the account.
		/// </summary>
		[JsonProperty("accountName")]
		public string AccountName { get; set; }

		/// <summary>
		/// Gets or sets the balance of the account.
		/// </summary>
		[JsonProperty("balance")]
		public decimal Balance { get; set; }
	}
}

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents the FDX model used for data exchange.
	/// </summary>
	public class FdxModel
	{
		/// <summary>
		/// Gets or sets the version of the FDX format.
		/// </summary>
		public string FdxVersion { get; set; }

		/// <summary>
		/// Gets or sets the message identifier.
		/// </summary>
		public string MessageId { get; set; }

		/// <summary>
		/// Gets or sets the type of message.
		/// </summary>
		public string MessageType { get; set; }

		/// <summary>
		/// Gets or sets the institution identifier.
		/// </summary>
		public string InstitutionId { get; set; }

		/// <summary>
		/// Gets or sets the client identifier.
		/// </summary>
		public string ClientId { get; set; }

		/// <summary>
		/// Gets or sets the account holder information.
		/// </summary>
		public AccountHolder AccountHolder { get; set; }

		/// <summary>
		/// Gets or sets the list of accounts.
		/// </summary>
		public List<Account> Accounts { get; set; }

		/// <summary>
		/// Gets or sets the transaction details.
		/// </summary>
		public TransactionDetails TransactionDetails { get; set; }
	}
}

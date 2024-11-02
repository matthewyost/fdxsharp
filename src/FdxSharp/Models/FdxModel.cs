using System.Collections.Generic;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

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
		[JsonPropertyName("fdxVersion")]
		public string FdxVersion { get; set; }

		/// <summary>
		/// Gets or sets the message identifier.
		/// </summary>
		[JsonPropertyName("messageId")]
		public string MessageId { get; set; }

		/// <summary>
		/// Gets or sets the type of message.
		/// </summary>
		[JsonPropertyName("messageType")]
		public string MessageType { get; set; }

		/// <summary>
		/// Gets or sets the institution identifier.
		/// </summary>
		[JsonPropertyName("institutionId")]
		public string InstitutionId { get; set; }

		/// <summary>
		/// Gets or sets the client identifier.
		/// </summary>
		[JsonPropertyName("clientId")]
		public string ClientId { get; set; }

		/// <summary>
		/// Gets or sets the account holder information.
		/// </summary>
		[JsonPropertyName("accountHolder")]
		public AccountHolder? AccountHolder { get; set; }

		/// <summary>
		/// Gets or sets the list of accounts.
		/// </summary>
		[JsonPropertyName("accounts")]
		public List<Account>? Accounts { get; set; }

		/// <summary>
		/// Gets or sets the transaction details.
		/// </summary>
		[JsonPropertyName("transactionDetails")]
		public TransactionDetails? TransactionDetails { get; set; }
	}
}

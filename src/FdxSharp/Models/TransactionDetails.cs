using System.Collections.Generic;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents transaction details, including a list of transactions.
	/// </summary>
	public class TransactionDetails
	{
		/// <summary>
		/// Gets or sets the list of transactions.
		/// </summary>
		[JsonPropertyName("transactions")]
		public List<Transaction>? Transactions { get; set; }
	}
}

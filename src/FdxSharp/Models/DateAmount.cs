using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Date Amount entity, A date and an amount
	/// </summary>
	public class DateAmount
	{
		/// <summary>
		/// Date
		/// </summary>
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }

		/// <summary>
		/// Description of item
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Amount
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

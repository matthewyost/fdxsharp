using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Capital Expenditure model.
	/// </summary>
	public class CapitalExpenditure
	{
		/// <summary>
		/// Date of the capital expenditure.
		/// </summary>
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }

		/// <summary>
		/// Description of the capital expenditure.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Amount of the capital expenditure.
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

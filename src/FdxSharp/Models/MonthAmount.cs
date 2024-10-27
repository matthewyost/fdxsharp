using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Month and Amount, Month and amount pair used on IRS Form 1099-K, etc.
	/// </summary>
	public class MonthAmount
	{
		/// <summary>
		/// Month
		/// </summary>
		[JsonPropertyName("month")]
		public MonthAbbreviationType Month { get; set; }

		/// <summary>
		/// Amount
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents a capital expenditure.
	/// </summary>
	public class CapitalExpenditure
	{
		/// <summary>
		/// The date of the capital expenditure.
		/// </summary>
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }

		/// <summary>
		/// The description of the capital expenditure.
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get; set; }

		/// <summary>
		/// The amount of the capital expenditure.
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

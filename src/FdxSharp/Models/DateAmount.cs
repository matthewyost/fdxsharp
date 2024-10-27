using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Date Amount
	/// </summary>
	public class DateAmount
	{
		/// <summary>
		/// Gets or sets the date.
		/// </summary>
		[JsonPropertyName("date")]
		public DateOnly Date { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

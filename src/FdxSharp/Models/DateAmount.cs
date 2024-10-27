using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	public class DateAmount
	{
		[JsonPropertyName("date")]
		public DateOnly Date { get; set; }

		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

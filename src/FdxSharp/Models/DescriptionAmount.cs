using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	public class DescriptionAmount
	{
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

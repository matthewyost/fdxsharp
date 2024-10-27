using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	public abstract class FiAttribute
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("value")]
		public string? Value { get; set; }
	}
}

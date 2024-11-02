using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Financial Institution Attribute
	/// </summary>
	public abstract class FiAttribute
	{
		/// <summary>
		/// Name of the attribute
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Value of the attribute
		/// </summary>
		[JsonPropertyName("value")]
		public string? Value { get; set; }
	}
}

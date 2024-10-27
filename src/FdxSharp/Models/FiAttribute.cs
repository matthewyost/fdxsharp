using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Financial Institution Attribute
	/// </summary>
	public abstract class FiAttribute
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		[JsonPropertyName("value")]
		public string? Value { get; set; }
	}
}

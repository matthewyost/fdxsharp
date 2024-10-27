using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// ttribute entity, A single attributeA
	/// </summary>
	public class Attribute
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		[JsonPropertyName("value")]
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the box number.
		/// </summary>
		[JsonPropertyName("boxNumber")]
		public string BoxNumber { get; set; }

		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		[JsonPropertyName("code")]
		public string Code { get; set; }
	}
}

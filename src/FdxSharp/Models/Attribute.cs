using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Attribute
	/// </summary>
	public class Attribute
	{
		/// <summary>
		/// Name of the Attribute
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Value of the Attribute
		/// </summary>
		[JsonPropertyName("value")]
		public string? Value { get; set; }

		/// <summary>
		/// Box Number of Attribute
		/// </summary>
		[JsonPropertyName("boxNumber")]
		public string? BoxNumber { get; set; }

		/// <summary>
		/// Attribute Code
		/// </summary>
		[JsonPropertyName("code")]
		public string? Code { get; set; }
	}
}

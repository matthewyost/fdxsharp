using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Individual name, First name, middle initial, last name, suffix fields
	/// </summary>
	public class IndividualName
	{
		/// <summary>
		/// First name.
		/// </summary>
		[JsonPropertyName("first")]
		public string? First { get; set; }

		/// <summary>
		/// Middle initial.
		/// </summary>
		[JsonPropertyName("middle")]
		public string? Middle { get; set; }

		/// <summary>
		/// Last name.
		/// </summary>
		[JsonPropertyName("last")]
		public string Last { get; set; }

		/// <summary>
		/// Generational or academic suffix.
		/// </summary>
		[JsonPropertyName("suffix")]
		public string? Suffix { get; set; }
	}
}

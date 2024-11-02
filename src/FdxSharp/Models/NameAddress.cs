using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Name and Address, Individual or business name with address
	/// </summary>
	public class NameAddress : Address
	{
		/// <summary>
		/// Name line 1
		/// </summary>
		[JsonPropertyName("name1")]
		public string? Name1 { get; set; }

		/// <summary>
		/// Name line 2
		/// </summary>
		[JsonPropertyName("name2")]
		public string? Name2 { get; set; }
	}
}

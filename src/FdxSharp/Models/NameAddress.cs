using System.Text.Json.Serialization;

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

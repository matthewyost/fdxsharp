using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Description Amount entity, A description and an amount
	/// </summary>
	public class DescriptionAmount
	{
		/// <summary>
		/// Description
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Amount
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

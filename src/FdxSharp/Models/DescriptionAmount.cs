using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Description Amount
	/// </summary>
	public class DescriptionAmount
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

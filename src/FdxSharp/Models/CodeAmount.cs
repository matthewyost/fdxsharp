using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Code and Amount, Code and amount pair used on IRS W-2, K-1, etc.
	/// </summary>
	public class CodeAmount
	{
		/// <summary>
		/// Code.
		/// </summary>
		[JsonPropertyName("code")]
		public string? Code { get; set; }

		/// <summary>
		/// Amount.
		/// </summary>
		[JsonPropertyName("amount")]
		public double Amount { get; set; }
	}
}

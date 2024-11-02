using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

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

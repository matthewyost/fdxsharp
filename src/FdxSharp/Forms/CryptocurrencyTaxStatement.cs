using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Cryptocurrency Tax Statement list, Array of cryptocurrency gains and losses
	/// </summary>
	public class CryptocurrencyTaxStatement : Tax
	{
		/// <summary>
		/// The list of cryptocurrency gains and losses
		/// </summary>
		[JsonPropertyName("gainsAndLosses")]
		public CryptocurrencyGainOrLoss[]? GainsAndLosses { get; set; }
	}
}

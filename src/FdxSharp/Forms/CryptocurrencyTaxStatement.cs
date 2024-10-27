using FdxSharp.Models;
using System.Text.Json.Serialization;

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

using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// State Tax Withholding, Income in a state and its tax withholding
	/// </summary>
	public class StateTaxWithholding
	{
		/// <summary>
		/// Amount of state income tax withheld.
		/// </summary>
		[JsonPropertyName("stateTaxWithheld")]
		public double StateTaxWithheld { get; set; }

		/// <summary>
		/// State two-digit code.
		/// </summary>
		[JsonPropertyName("state")]
		public string? State { get; set; }

		/// <summary>
		/// Tax id of company withholding state income tax.
		/// </summary>
		[JsonPropertyName("stateTaxId")]
		public string? StateTaxId { get; set; }

		/// <summary>
		/// Income amount for state tax purposes.
		/// </summary>
		[JsonPropertyName("stateIncome")]
		public double StateIncome { get; set; }
	}
}

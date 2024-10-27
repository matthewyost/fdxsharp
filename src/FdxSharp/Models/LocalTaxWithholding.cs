using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Local Tax Withholding, Income in a locality and its tax withholding
	/// </summary>
	public class LocalTaxWithholding
	{
		/// <summary>
		/// Amount of local income tax withheld
		/// </summary>
		[JsonPropertyName("localTaxWithheld")]
		public double LocalTaxWithheld { get; set; }

		/// <summary>
		/// Locality name
		/// </summary>
		[JsonPropertyName("localityName")]
		public string? LocalityName { get; set; }

		/// <summary>
		/// State code of state in which locality exists
		/// </summary>
		[JsonPropertyName("state")]
		public string? State { get; set; }

		/// <summary>
		/// Income amount for local tax purposes
		/// </summary>
		[JsonPropertyName("localIncome")]
		public double LocalIncome { get; set; }
	}
}

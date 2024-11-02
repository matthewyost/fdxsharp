using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Form 1042-S Agent, One of various persons or businesses involved in Form 1042-S reporting
	/// </summary>
	public class Form1042Agent : NameAddress
	{
		/// <summary>
		/// Agent's EIN.
		/// </summary>
		[JsonPropertyName("agentTin")]
		public string? AgentTin { get; set; }

		/// <summary>
		/// Ch. 3 status code.
		/// </summary>
		[JsonPropertyName("ch3StatusCode")]
		public string? Ch3StatusCode { get; set; }

		/// <summary>
		/// Ch. 4 status code.
		/// </summary>
		[JsonPropertyName("ch4StatusCode")]
		public string? Ch4StatusCode { get; set; }

		/// <summary>
		/// Agent's Global Intermediary Identification Number (GIIN).
		/// </summary>
		[JsonPropertyName("giin")]
		public string? Giin { get; set; }

		/// <summary>
		/// Country code.
		/// </summary>
		[JsonPropertyName("countryCode")]
		public string? CountryCode { get; set; }

		/// <summary>
		/// Foreign tax identification number, if any.
		/// </summary>
		[JsonPropertyName("foreignTin")]
		public string? ForeignTin { get; set; }
	}
}

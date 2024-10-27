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
		public string? AgentTin { get; set; }

		/// <summary>
		/// Ch. 3 status code.
		/// </summary>
		public string? Ch3StatusCode { get; set; }

		/// <summary>
		/// Ch. 4 status code.
		/// </summary>
		public string? Ch4StatusCode { get; set; }

		/// <summary>
		/// Agent's Global Intermediary Identification Number (GIIN).
		/// </summary>
		public string? Giin { get; set; }

		/// <summary>
		/// Country code.
		/// </summary>
		public string? CountryCode { get; set; }

		/// <summary>
		/// Foreign tax identification number, if any.
		/// </summary>
		public string? ForeignTin { get; set; }
	}
}

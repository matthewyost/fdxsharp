using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098-MA, Mortgage Assistance Payments
	/// </summary>
	public class Tax1098Ma : Tax
	{
		/// <summary>
		/// FILER'S name, street address, city, state, ZIP code, and telephone no.
		/// </summary>
		[JsonPropertyName("filerNameAddress")]
		public NameAddressPhone? FilerNameAddress { get; set; }

		/// <summary>
		/// FILER'S TIN
		/// </summary>
		[JsonPropertyName("filerTin")]
		public string? FilerTin { get; set; }

		/// <summary>
		/// HOMEOWNER'S TIN
		/// </summary>
		[JsonPropertyName("homeownerTin")]
		public string? HomeownerTin { get; set; }

		/// <summary>
		/// Homeowner's name and address
		/// </summary>
		[JsonPropertyName("homeownerNameAddress")]
		public NameAddress? HomeownerNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Total State HFA (Housing Finance Agency) and homeowner mortgage payments
		/// </summary>
		[JsonPropertyName("totalMortgagePayments")]
		public double TotalMortgagePayments { get; set; }

		/// <summary>
		/// Box 2, State HFA (Housing Finance Agency) mortgage assistance payments
		/// </summary>
		[JsonPropertyName("mortgageAssistancePayments")]
		public double MortgageAssistancePayments { get; set; }

		/// <summary>
		/// Box 3, Homeowner mortgage payments
		/// </summary>
		[JsonPropertyName("homeownerMortgagePayments")]
		public double HomeownerMortgagePayments { get; set; }
	}
}

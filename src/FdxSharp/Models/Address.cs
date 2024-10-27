using FdxSharp.Enums;

namespace FdxSharp.Models
{
	public class Address
	{
		/// <summary>
		/// Address Line 1
		/// </summary>
		[JsonProperty("line1")]
		public string? Line1 { get; set; }

		/// <summary>
		/// Address Line 2
		/// </summary>
		[JsonProperty("line2")]
		public string? Line2 { get; set; }

		/// <summary>
		/// Address Line 3
		/// </summary>
		[JsonProperty("line3")]
		public string? Line3 { get; set; }

		/// <summary>
		/// City
		/// </summary>
		[JsonProperty("city")]
		public string? City { get; set; }

		/// <summary>
		/// State
		/// </summary>
		[JsonProperty("state")]
		public string? State { get; set; }

		/// <summary>
		/// Region
		/// </summary>
		[JsonProperty("region")]
		public string? Region { get; set; }

		/// <summary>
		/// Postal Code
		/// </summary>
		[JsonProperty("postalCode")]
		public string? PostalCode { get; set; }

		/// <summary>
		/// Country
		/// </summary>
		[JsonProperty("country")]
		public CountryCodeType Country { get; set; }
	}
}

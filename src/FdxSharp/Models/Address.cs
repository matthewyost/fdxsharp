using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents an Address.
	/// </summary>
	public class Address
	{
		/// <summary>
		/// Gets or sets Address Line 1.
		/// </summary>
		[JsonPropertyName("line1")]
		public string? Line1 { get; set; }

		/// <summary>
		/// Gets or sets Address Line 2.
		/// </summary>
		[JsonPropertyName("line2")]
		public string? Line2 { get; set; }

		/// <summary>
		/// Gets or sets Address Line 3.
		/// </summary>
		[JsonPropertyName("line3")]
		public string? Line3 { get; set; }

		/// <summary>
		/// Gets or sets City.
		/// </summary>
		[JsonPropertyName("city")]
		public string? City { get; set; }

		/// <summary>
		/// Gets or sets State.
		/// </summary>
		[JsonPropertyName("state")]
		public string? State { get; set; }

		/// <summary>
		/// Gets or sets Region. Can be a State, Province, or Territory. Replaces "state" property.
		/// </summary>
		[JsonPropertyName("region")]
		public string? Region { get; set; }

		/// <summary>
		/// Gets or sets Postal Code.
		/// </summary>
		[JsonPropertyName("postalCode")]
		public string? PostalCode { get; set; }

		/// <summary>
		/// Gets or sets the Country. Iso3166CountryCode Type.
		/// </summary>
		[JsonPropertyName("country")]
		public CountryCodeType Country { get; set; }
	}
}

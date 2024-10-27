using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Name, Address and Phone, Contact phone number with name and address
	/// </summary>
	public class NameAddressPhone : NameAddress
	{
		/// <summary>
		/// Phone number.
		/// </summary>
		[JsonPropertyName("phone")]
		public TelephoneNumberPlusExtension Phone { get; set; }
	}
}

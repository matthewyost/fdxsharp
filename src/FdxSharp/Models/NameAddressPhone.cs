using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

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
		public TelephoneNumberPlusExtension? Phone { get; set; }
	}
}

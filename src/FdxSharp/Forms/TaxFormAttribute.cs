using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Tax Form Attribute, An additional tax form attribute for use when a defined field is not available
	/// </summary>
	public class TaxFormAttribute : FiAttribute
	{
		/// <summary>
		/// Box number on a tax form, if any
		/// </summary>
		[JsonPropertyName("boxNumber")]
		public string? BoxNumber { get; set; }

		/// <summary>
		/// Tax form code for the given box number, if any
		/// </summary>
		[JsonPropertyName("code")]
		public string? Code { get; set; }
	}
}

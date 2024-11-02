using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp
{
	/// <summary>
	/// Tax Data List, Paginated array of tax data
	/// </summary>
	public class TaxDataList : PaginatedArray
	{
		/// <summary>
		/// The list of tax forms.
		/// </summary>
		[JsonPropertyName("forms")]
		public TaxData[]? Forms { get; set; }
	}
}

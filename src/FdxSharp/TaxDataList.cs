using System.Text.Json.Serialization;

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

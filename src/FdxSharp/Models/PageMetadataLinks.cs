using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Page Metadata Links, Resource URLs for retrieving next or previous datasets
	/// </summary>
	public class PageMetadataLinks
	{
		/// <summary>
		/// Resource URL for retrieving next dataset
		/// </summary>
		[JsonPropertyName("next")]
		public HateoasLink? Next { get; set; }

		/// <summary>
		/// Resource URL for retrieving previous dataset
		/// </summary>
		[JsonPropertyName("prev")]
		public HateoasLink? Prev { get; set; }
	}
}

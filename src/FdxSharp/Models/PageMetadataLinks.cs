using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

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

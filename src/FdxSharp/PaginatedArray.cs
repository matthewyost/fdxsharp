using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp
{
	/// <summary>
	/// Paginated Array, Base class for results that may be paginated
	/// </summary>
	public class PaginatedArray
	{
		/// <summary>
		/// Offset IDs for navigating result sets
		/// </summary>
		[JsonPropertyName("page")]
		public PageMetadata? Page { get; set; }

		/// <summary>
		/// Resource URLs for navigating result sets
		/// </summary>
		[JsonPropertyName("links")]
		public PageMetadataLinks? Links { get; set; }
	}
}

using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Page Metadata, Offset IDs for paginated result sets
	/// </summary>
	public class PageMetadata
	{
		/// <summary>
		/// Opaque identifier. Does not need to be numeric or have any specific pattern. Implementation specific
		/// </summary>
		[JsonPropertyName("nextOffset")]
		public string? NextOffset { get; set; }

		/// <summary>
		/// Opaque identifier. Does not need to be numeric or have any specific pattern. Implementation specific
		/// </summary>
		[JsonPropertyName("prevOffset")]
		public string? PrevOffset { get; set; }

		/// <summary>
		/// Total number of elements
		/// </summary>
		[JsonPropertyName("totalElements")]
		public int TotalElements { get; set; }
	}
}

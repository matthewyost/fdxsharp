using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Customers Entity, List of customers
	/// </summary>
	public class Customers
	{
		/// <summary>
		/// Information required to paginate results
		/// </summary>
		[JsonPropertyName("page")]
		public PageMetadata? Page { get; set; }

		/// <summary>
		/// Links used to paginate results
		/// </summary>
		[JsonPropertyName("links")]
		public PageMetadataLinks? Links { get; set; }

		/// <summary>
		/// Array of customers
		/// </summary>
		[JsonPropertyName("customers")]
		public Customer[]? CustomersArray { get; set; }
	}
}

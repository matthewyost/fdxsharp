using FdxSharp.Enums;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Consent Requested Resource entity, Details of requested resource and data clusters
	/// </summary>
	public class ConsentRequestedResource
	{
		/// <summary>
		/// Type of resource permission requested
		/// </summary>
		[JsonPropertyName("resourceType")]
		public ConsentResourceType? ResourceType { get; set; }

		/// <summary>
		/// Name of clusters of data elements requested.
		/// </summary>
		[JsonPropertyName("dataClusters")]
		public DataClusterType[]? DataClusters { get; set; }
	}
}

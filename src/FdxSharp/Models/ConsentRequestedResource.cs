using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

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

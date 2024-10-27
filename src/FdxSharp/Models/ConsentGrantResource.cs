using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Consent Grant Resource entity, Entity of permissioned resources
/// </summary>
public class ConsentGrantResource
{
	/// <summary>
	/// Type of resource to be permissioned
	/// </summary>
	[JsonPropertyName("resourceType")]
	public ConsentResourceType? ResourceType { get; set; }

	/// <summary>
	/// Identifier of resource to be permissioned
	/// </summary>
	[JsonPropertyName("resourceId")]
	public string? ResourceId { get; set; }

	/// <summary>
	/// Names of clusters of data elements permissioned
	/// </summary>
	[JsonPropertyName("dataClusters")]
	public DataClusterType[]? DataClusters { get; set; }
}

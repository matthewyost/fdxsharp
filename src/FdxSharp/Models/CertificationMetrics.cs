using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Certification Metrics entity, Response object for /certification-metrics API
/// </summary>
public class CertificationMetrics
{
	/// <summary>
	/// Zero or more certification performance metrics
	/// </summary>
	[JsonPropertyName("metrics")]
	public CertificationMetric[]? Metrics { get; set; }
}

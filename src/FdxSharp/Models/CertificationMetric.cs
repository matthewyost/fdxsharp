using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Certification Metric entity, A single certification performance metric
/// </summary>
public class CertificationMetric
{
	/// <summary>
	/// When the reported metrics period began
	/// </summary>
	[JsonPropertyName("reportStartTimestamp")]
	public DateTime? ReportStartTimestamp { get; set; }

	/// <summary>
	/// When the reported metrics period ended
	/// </summary>
	[JsonPropertyName("reportEndTimestamp")]
	public DateTime? ReportEndTimestamp { get; set; }

	/// <summary>
	/// Any provider descriptive name for the measurement. Optional, can be omitted if operationIds are returned
	/// </summary>
	[JsonPropertyName("metricsName")]
	public string? MetricsName { get; set; }

	/// <summary>
	/// One or more Operation IDs for which these metrics apply. Optional, can be omitted if metricsName is returned
	/// </summary>
	[JsonPropertyName("operationIds")]
	public OperationIdType[]? OperationIds { get; set; }

	/// <summary>
	/// The self-reported average response time in milliseconds for all combined data responses
	/// </summary>
	[JsonPropertyName("responseTimeAverage")]
	public double ResponseTimeAverage { get; set; }

	/// <summary>
	/// See the Certification Performance section that describes how this measurement will be calculated, defines the % of availability during the measurement
	/// </summary>
	[JsonPropertyName("averageUpTime")]
	public double AverageUpTime { get; set; }

	/// <summary>
	/// Time when these performance and availability metrics were created
	/// </summary>
	[JsonPropertyName("reportTimestamp")]
	public DateTime? ReportTimestamp { get; set; }
}

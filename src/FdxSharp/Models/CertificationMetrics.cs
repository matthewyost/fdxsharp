using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
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
}

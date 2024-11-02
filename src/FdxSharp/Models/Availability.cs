using FdxSharp.Enums;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Availability
	/// </summary>
	public class Availability
	{
		/// <summary>
		/// Status of the Availability
		/// </summary>
		[JsonPropertyName("status")]
		public AvailabilityStatusType Status { get; set; }

		/// <summary>
		/// Availability Description
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Operation's availability
		/// </summary>
		[JsonPropertyName("operationId")]
		public OperationIdType OperationId { get; set; }

		/// <summary>
		/// Planned Availabilities
		/// </summary>
		[JsonPropertyName("plannedAvailability")]
		public PlannedAvailability[]? PlannedAvailability { get; set; }
	}
}

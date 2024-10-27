using System.Text.Json.Serialization;
using FdxSharp.Enums;

namespace FdxSharp.Models
{
	/// <summary>
	/// Availability entity
	/// </summary>
	public class Availability
	{
		/// <summary>
		/// Get or set the availability status.
		/// </summary>
		[JsonPropertyName("status")]
		public AvailabilityStatusType Status { get; set; }

		/// <summary>
		/// Get or set the description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Get or set the operation id.
		/// </summary>
		[JsonPropertyName("operationId")]
		public OperationIdType OperationId { get; set; }

		/// <summary>
		/// Get or set the planned availability.
		/// </summary>
		[JsonPropertyName("plannedAvailability")]
		public PlannedAvailability[]? PlannedAvailability { get; set; }
	}
}

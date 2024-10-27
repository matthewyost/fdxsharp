using System.Text.Json.Serialization;
using FdxSharp.Enums;

namespace FdxSharp.Models
{
	/// <summary>
	/// Providers planned API availability
	/// </summary>
	public class PlannedAvailability
	{
		/// <summary>
		/// Gets or sets Availability status.
		/// </summary>
		[JsonPropertyName("status")]
		public AvailabilityStatusType Status { get; set; }

		/// <summary>
		/// Gets or sets Availability description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or sets Start time.
		/// </summary>
		[JsonPropertyName("startTime")]
		public TimeOnly StartTime { get; set; }

		/// <summary>
		/// Gets or sets End time.
		/// </summary>
		[JsonPropertyName("endTime")]
		public TimeOnly EndTime { get; set; }
	}
}

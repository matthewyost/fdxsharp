using FdxSharp.Enums;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Planned Availability
	/// </summary>
	public class PlannedAvailability
	{
		/// <summary>
		/// Status of Availability
		/// </summary>
		public AvailabilityStatusType Status { get; set; }

		/// <summary>
		/// Description
		/// </summary>
		public string? Description { get; set; }

		/// <summary>
		/// Start Time
		/// </summary>
		public string StartTime { get; set; }

		/// <summary>
		/// End Time
		/// </summary>
		public string EndTime { get; set; }
	}
}

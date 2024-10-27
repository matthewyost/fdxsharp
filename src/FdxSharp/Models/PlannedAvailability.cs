using FdxSharp.Enums;

namespace FdxSharp.Models
{
	public class PlannedAvailability
	{
		public AvailabilityStatusType Status { get; set; }

		public string? Description { get; set; }

		public TimeOnly StartTime { get; set; }

		public TimeOnly EndTime { get; set; }
	}
}

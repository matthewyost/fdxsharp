using FdxSharp.Enums;

namespace FdxSharp.Models
{
	public class Availability
	{
		public AvailabilityStatusType Status { get; set; }

		public string? Description { get; set; }

		public OperationIdType OperationId { get; set; }

		public PlannedAvailability[]? PlannedAvailability { get; set; }
	}
}

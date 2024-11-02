using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Suspected Fraud Incident entity, Notification of suspected fraud
	/// </summary>
	public class SuspectedFraudIncident
	{
		/// <summary>
		/// Extensible string enum identifying the type of suspected fraud. Initially this will always be set to "ACCOUNT_TAKEOVER". Additional values may be defined in the future.
		/// </summary>
		[JsonPropertyName("type")]
		public string? Type { get; set; }

		/// <summary>
		/// Unique identifier for the fraud incident.
		/// </summary>
		[JsonPropertyName("incidentId")]
		public string? IncidentId { get; set; }

		/// <summary>
		/// Free text justification for suspected fraud
		/// </summary>
		[JsonPropertyName("reason")]
		public string? Reason { get; set; }

		/// <summary>
		/// Array of financial institution-specific attributes. Can be used to provide additional structured context on the suspected fraud for the FI to use in determining a resolution.
		/// </summary>
		[JsonPropertyName("fiAttributes")]
		public FiAttribute[]? FiAttributes { get; set; }

		/// <summary>
		/// Identity of the party responsible for identifying and reporting the suspected fraud. This might be the DP, DAP, a vendor, a payment network, or other entity.
		/// </summary>
		[JsonPropertyName("reporter")]
		public Party? Reporter { get; set; }
	}
}

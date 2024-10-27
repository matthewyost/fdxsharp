using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Consent request entity, Details of request to create new consent grant. This schema 
/// is to be used in POST request to Data Providerâ€™s 'POST /par' endpoint using the 
/// Pushed Authorization Request (PAR) method
/// </summary>
public class ConsentRequest
{
	/// <summary>
	/// The type of duration of the consent
	/// </summary>
	[JsonPropertyName("durationType")]
	public ConsentDurationType? DurationType { get; set; }

	/// <summary>
	/// The consent duration in days from day of original grant
	/// </summary>
	[JsonPropertyName("durationPeriod")]
	public int? DurationPeriod { get; set; }

	/// <summary>
	/// Period, in days, for which historical data may be requested; measured from request time, not grant time
	/// </summary>
	[JsonPropertyName("lookbackPeriod")]
	public int? LookbackPeriod { get; set; }

	/// <summary>
	/// The requested resource entities
	/// </summary>
	[JsonPropertyName("resources")]
	public ConsentRequestedResource[]? Resources { get; set; }
}

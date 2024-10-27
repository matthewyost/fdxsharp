using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Customer Name entity, The name of an individual in their role as a customer
/// </summary>
public class CustomerName : IndividualName
{
	/// <summary>
	/// Name prefix, e.g. Mr.
	/// </summary>
	[JsonPropertyName("prefix")]
	public string? Prefix { get; set; }

	/// <summary>
	/// Company name
	/// </summary>
	[JsonPropertyName("company")]
	public string? Company { get; set; }
}

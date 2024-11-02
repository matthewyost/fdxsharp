using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
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
}

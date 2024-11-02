using FdxSharp.Enums;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Party entity, FDX Participant - an entity or person that is a part of a FDX API transaction
	/// </summary>
	public class Party
	{
		/// <summary>
		/// Human recognizable common name
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Extensible string enum identifying the type of the party
		/// </summary>
		[JsonPropertyName("type")]
		public PartyType? Type { get; set; }

		/// <summary>
		/// URI for party, where an end user could learn more about the company or application involved in the data sharing chain
		/// </summary>
		[JsonPropertyName("homeUri")]
		public string? HomeUri { get; set; }

		/// <summary>
		/// URI for a logo asset to be displayed to the end user
		/// </summary>
		[JsonPropertyName("logoUri")]
		public string? LogoUri { get; set; }

		/// <summary>
		/// The registry containing the party's registration with name and id: FDX, GLEIF, ICANN, PRIVATE
		/// </summary>
		[JsonPropertyName("registry")]
		public PartyRegistryType? Registry { get; set; }

		/// <summary>
		/// Registered name of party
		/// </summary>
		[JsonPropertyName("registeredEntityName")]
		public string? RegisteredEntityName { get; set; }

		/// <summary>
		/// Registered id of party
		/// </summary>
		[JsonPropertyName("registeredEntityId")]
		public string? RegisteredEntityId { get; set; }
	}
}

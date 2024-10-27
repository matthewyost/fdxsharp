using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Customer to Account Relationship entity, Describes an account related to a customer
/// </summary>
public class CustomerToAccountRelationship
{
	/// <summary>
	/// Account ID of the related account
	/// </summary>
	[JsonPropertyName("accountId")]
	public string? AccountId { get; set; }

	/// <summary>
	/// Links to the account, or to invoke other APIs
	/// </summary>
	[JsonPropertyName("links")]
	public HateoasLink[]? Links { get; set; }

	/// <summary>
	/// Type of relationship to the account
	/// </summary>
	[JsonPropertyName("relationship")]
	public AccountHolderRelationshipType? Relationship { get; set; }
}

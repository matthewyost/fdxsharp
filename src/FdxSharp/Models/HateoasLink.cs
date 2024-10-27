using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// HATEOAS Link, REST application constraint (Hypermedia As The Engine Of Application State)
	/// </summary>
	public class HateoasLink
	{
		/// <summary>
		/// URL to invoke the action on the resource
		/// </summary>
		[JsonPropertyName("href")]
		public string? Href { get; set; }

		/// <summary>
		/// HTTP Method to use for the request
		/// </summary>
		[JsonPropertyName("action")]
		public string? Action { get; set; }

		/// <summary>
		/// Relation of this link to its containing entity, as defined by and with many example relation values at IETF RFC5988
		/// </summary>
		[JsonPropertyName("rel")]
		public string? Rel { get; set; }

		/// <summary>
		/// Content-types that can be used in the Accept header
		/// </summary>
		[JsonPropertyName("types")]
		public ContentType[]? Types { get; set; }
	}
}

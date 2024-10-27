using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents an error.
	/// </summary>
	public class Error
	{
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		[JsonPropertyName("code")]
		public string Code { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}

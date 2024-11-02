using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Error
	/// </summary>
	public class Error
	{
		/// <summary>
		/// Error Code
		/// </summary>
		[JsonPropertyName("code")]
		public string Code { get; set; }

		/// <summary>
		/// Error Message
		/// </summary>
		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}

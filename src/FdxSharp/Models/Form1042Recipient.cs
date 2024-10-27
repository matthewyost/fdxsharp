using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Form 1042-S Recipient, Information about recipient of Form 1042-S
	/// </summary>
	public class Form1042Recipient : Form1042Agent
	{
		/// <summary>
		/// LOB code number, if any.
		/// </summary>
		[JsonPropertyName("lobCode")]
		public string? LobCode { get; set; }

		/// <summary>
		/// Date of birth.
		/// </summary>
		[JsonPropertyName("dateOfBirth")]
		public DateOnly DateOfBirth { get; set; }
	}
}

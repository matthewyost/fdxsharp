using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Represents an account holder's information.
	/// </summary>
	public class AccountHolder
	{
		/// <summary>
		/// Gets or sets the first name of the account holder.
		/// </summary>
		[JsonPropertyName("firstName")]
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name of the account holder.
		/// </summary>
		[JsonPropertyName("lastName")]
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the address of the account holder.
		/// </summary>
		[JsonPropertyName("address")]
		public string? Address { get; set; }

		/// <summary>
		/// Gets or sets the phone number of the account holder.
		/// </summary>
		[JsonPropertyName("phoneNumer")]
		public string? PhoneNumber { get; set; }

		/// <summary>
		/// Gets or sets the email address of the account holder.
		/// </summary>
		[JsonPropertyName("email")]
		public string? Email { get; set; }
	}
}

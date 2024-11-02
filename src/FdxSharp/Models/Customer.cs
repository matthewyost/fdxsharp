using FdxSharp.Enums;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Models
{
	/// <summary>
	/// Customer entity, Represents a customer
	/// </summary>
	public class Customer
	{
		/// <summary>
		/// Long-term persistent identity of the customer. This identity must be unique to the owning institution
		/// </summary>
		[JsonPropertyName("customerId")]
		public string? CustomerId { get; set; }

		/// <summary>
		/// The customer's name
		/// </summary>
		[JsonPropertyName("name")]
		public CustomerName? Name { get; set; }

		/// <summary>
		/// The customer's date of birth
		/// </summary>
		[JsonPropertyName("dateOfBirth")]
		public DateTime? DateOfBirth { get; set; }

		/// <summary>
		/// Country specific Tax Id associated with this customer (SIN or NAS in Canada, SSN or TIN in US, etc.)
		/// </summary>
		[JsonPropertyName("taxId")]
		public string? TaxId { get; set; }

		/// <summary>
		/// Country originating the Customer's taxId element
		/// </summary>
		[JsonPropertyName("taxIdCountry")]
		public CountryCodeType? TaxIdCountry { get; set; }

		/// <summary>
		/// A federal (such as passport) or state (such as driver's license) issued identifier
		/// </summary>
		[JsonPropertyName("governmentId")]
		public string? GovernmentId { get; set; }

		/// <summary>
		/// An array of the customer's electronic mail addresses
		/// </summary>
		[JsonPropertyName("email")]
		public string[]? Email { get; set; }

		/// <summary>
		/// An array of the customer's physical mail addresses
		/// </summary>
		[JsonPropertyName("addresses")]
		public DeliveryAddress[]? Addresses { get; set; }

		/// <summary>
		/// An array of the customer's telephone numbers
		/// </summary>
		[JsonPropertyName("telephones")]
		public TelephoneNumber[]? Telephones { get; set; }

		/// <summary>
		/// List of accounts related to this customer
		/// </summary>
		[JsonPropertyName("accounts")]
		public CustomerToAccountRelationship[]? Accounts { get; set; }
	}
}

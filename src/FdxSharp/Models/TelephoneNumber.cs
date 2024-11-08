﻿using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Title: Telephone Number Type
	/// Description: Purpose or type of telephone number
	/// </summary>
	public enum TelephoneNumberType
	{
		/// <summary>
		/// Home Telephone
		/// </summary>
		HOME,
		/// <summary>
		/// Business Telephone
		/// </summary>
		BUSINESS,
		/// <summary>
		/// Cellular Telephone
		/// </summary>
		CELL,
		/// <summary>
		/// Fax
		/// </summary>
		FAX
	}

	/// <summary>
	/// Telephone Number, Standard for international phone numbers
	/// </summary>
	public class TelephoneNumber
	{
		/// <summary>
		/// Type of phone number: HOME, BUSINESS, CELL, FAX.
		/// </summary>
		[JsonPropertyName("type")]
		public TelephoneNumberType Type { get; set; }

		/// <summary>
		/// Country calling codes defined by ITU-T recommendations E.123 and E.164.
		/// </summary>
		[JsonPropertyName("country")]
		public string Country { get; set; }

		/// <summary>
		/// Telephone subscriber number defined by ITU-T recommendation E.164.
		/// </summary>
		[JsonPropertyName("number")]
		public string Number { get; set; }
	}

	/// <summary>
	/// Telephone Number Plus Extension, A telephone number that can contain optional text for an arbitrary length telephone extension number
	/// </summary>
	public class TelephoneNumberPlusExtension : TelephoneNumber
	{
		/// <summary>
		/// An arbitrary length telephone number extension
		/// </summary>
		[JsonPropertyName("extension")]
		public string Extension { get; set; }
	}
}

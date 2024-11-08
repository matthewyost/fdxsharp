﻿using FdxSharp.Enums;
using System.Text.Json.Serialization;

namespace FdxSharp.Models;

/// <summary>
/// Represents a delivery address.
/// </summary>
public class DeliveryAddress : Address
{
	/// <summary>
	/// Type of address location. One of BUSINESS, HOME, MAILING
	/// </summary>
	[JsonPropertyName("type")]
	public DeliveryAddressType? Type { get; set; }
}

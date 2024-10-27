﻿using FdxSharp.Enums;

namespace FdxSharp.Models
{
	public class Address
	{
		public string? Line1 { get; set; }

		public string? Line2 { get; set; }

		public string? Line3 { get; set; }

		public string? City { get; set; }

		public string? State { get; set; }

		public string? Region { get; set; }

		public string? PostalCode { get; set; }

		public CountryCodeType Country { get; set; }
	}
}
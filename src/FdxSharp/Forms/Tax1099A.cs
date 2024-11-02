using FdxSharp.Models;
using System;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-A, Acquisition or Abandonment of Secured Property
	/// </summary>
	public class Tax1099A : Tax
	{
		/// <summary>
		/// Lender's name, address, and phone
		/// </summary>
		[JsonPropertyName("lenderNameAddress")]
		public NameAddressPhone? LenderNameAddress { get; set; }

		/// <summary>
		/// LENDER'S TIN
		/// </summary>
		[JsonPropertyName("lenderTin")]
		public string? LenderTin { get; set; }

		/// <summary>
		/// BORROWER'S TIN
		/// </summary>
		[JsonPropertyName("borrowerTin")]
		public string? BorrowerTin { get; set; }

		/// <summary>
		/// Borrower's name and address
		/// </summary>
		[JsonPropertyName("borrowerNameAddress")]
		public NameAddress? BorrowerNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Date of lender's acquisition or knowledge of abandonment
		/// </summary>
		[JsonPropertyName("dateOfAcquisition")]
		public DateTime DateOfAcquisition { get; set; }

		/// <summary>
		/// Box 2, Balance of principal outstanding
		/// </summary>
		[JsonPropertyName("principalBalance")]
		public double PrincipalBalance { get; set; }

		/// <summary>
		/// Box 4, Fair market value property
		/// </summary>
		[JsonPropertyName("fairMarketValue")]
		public double FairMarketValue { get; set; }

		/// <summary>
		/// Box 5, If checked, the borrower was personally liable for repayment of the debt
		/// </summary>
		[JsonPropertyName("personallyLiable")]
		public bool PersonallyLiable { get; set; }

		/// <summary>
		/// Box 6, Description of property
		/// </summary>
		[JsonPropertyName("propertyDescription")]
		public string? PropertyDescription { get; set; }
	}
}

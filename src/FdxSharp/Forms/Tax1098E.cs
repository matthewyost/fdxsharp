using FdxSharp.Models;
using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098-E, Student Loan Interest Statement
	/// </summary>
	public class Tax1098E : Tax
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
		/// Box 1, Student loan interest received by lender
		/// </summary>
		[JsonPropertyName("studentLoanInterest")]
		public double StudentLoanInterest { get; set; }

		/// <summary>
		/// Box 2, If checked, box 1 does not include loan origination fee made before September 1, 2004
		/// </summary>
		[JsonPropertyName("box1ExcludesFees")]
		public bool Box1ExcludesFees { get; set; }
	}
}

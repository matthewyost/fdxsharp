using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098, Mortgage Interest Statement
	/// </summary>
	public class Tax1098 : Tax
	{
		/// <summary>
		/// Lender's name, address and phone
		/// </summary>
		[JsonPropertyName("lenderNameAddress")]
		public NameAddressPhone LenderNameAddress { get; set; }

		/// <summary>
		/// RECIPIENT'S/LENDER'S TIN
		/// </summary>
		[JsonPropertyName("lenderTin")]
		public string LenderTin { get; set; }

		/// <summary>
		/// PAYER'S/BORROWER'S TIN
		/// </summary>
		[JsonPropertyName("borrowerTin")]
		public string BorrowerTin { get; set; }

		/// <summary>
		/// Borrower's name and address
		/// </summary>
		[JsonPropertyName("borrowerNameAddress")]
		public NameAddress BorrowerNameAddress { get; set; }

		/// <summary>
		/// Box 9, Number of properties securing the mortgage
		/// </summary>
		[JsonPropertyName("mortgagedProperties")]
		public int MortgagedProperties { get; set; }

		/// <summary>
		/// Box 10, Other (property tax)
		/// </summary>
		[JsonPropertyName("otherInformation")]
		public string OtherInformation { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string AccountNumber { get; set; }

		/// <summary>
		/// Box 1, Mortgage interest received from borrower
		/// </summary>
		[JsonPropertyName("mortgageInterest")]
		public double MortgageInterest { get; set; }

		/// <summary>
		/// Box 2, Outstanding mortgage principal
		/// </summary>
		[JsonPropertyName("outstandingPrincipal")]
		public double OutstandingPrincipal { get; set; }

		/// <summary>
		/// Box 3, Mortgage origination date
		/// </summary>
		[JsonPropertyName("originationDate")]
		public DateTime OriginationDate { get; set; }

		/// <summary>
		/// Box 4, Refund of overpaid interest
		/// </summary>
		[JsonPropertyName("overpaidRefund")]
		public double OverpaidRefund { get; set; }

		/// <summary>
		/// Box 5, Mortgage insurance premiums
		/// </summary>
		[JsonPropertyName("mortgageInsurance")]
		public double MortgageInsurance { get; set; }

		/// <summary>
		/// Box 6, Points paid on purchase of principal residence
		/// </summary>
		[JsonPropertyName("pointsPaid")]
		public double PointsPaid { get; set; }

		/// <summary>
		/// Box 7, Is address of property securing mortgage same as PAYER'S/BORROWER'S address
		/// </summary>
		[JsonPropertyName("isPropertyAddressSameAsBorrowerAddress")]
		public bool IsPropertyAddressSameAsBorrowerAddress { get; set; }

		/// <summary>
		/// Box 11, Mortgage acquisition date
		/// </summary>
		[JsonPropertyName("acquisitionDate")]
		public DateTime AcquisitionDate { get; set; }

		/// <summary>
		/// Box 8, Address of property securing mortgage
		/// </summary>
		[JsonPropertyName("propertyAddress")]
		public Address PropertyAddress { get; set; }

		/// <summary>
		/// Box 10, Property tax
		/// </summary>
		[JsonPropertyName("propertyTax")]
		public double PropertyTax { get; set; }

		/// <summary>
		/// Box 8, Description of property securing mortgage, if property securing mortgage has no address
		/// </summary>
		[JsonPropertyName("propertyDescription")]
		public string PropertyDescription { get; set; }
	}
}

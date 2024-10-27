using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098-C, Contributions of Motor Vehicles, Boats, and Airplanes
	/// </summary>
	public class Tax1098C : Tax
	{
		/// <summary>
		/// Donee's name, address and phone
		/// </summary>
		[JsonPropertyName("doneeNameAddress")]
		public NameAddressPhone DoneeNameAddress { get; set; }

		/// <summary>
		/// DONEE'S TIN
		/// </summary>
		[JsonPropertyName("doneeTin")]
		public string DoneeTin { get; set; }

		/// <summary>
		/// DONOR'S TIN
		/// </summary>
		[JsonPropertyName("donorTin")]
		public string DonorTin { get; set; }

		/// <summary>
		/// Donor's name and address
		/// </summary>
		[JsonPropertyName("donorNameAddress")]
		public NameAddress DonorNameAddress { get; set; }

		/// <summary>
		/// Box 1, Date of contribution
		/// </summary>
		[JsonPropertyName("dateOfContribution")]
		public DateTime DateOfContribution { get; set; }

		/// <summary>
		/// Box 2a, Odometer mileage
		/// </summary>
		[JsonPropertyName("odometerMileage")]
		public int OdometerMileage { get; set; }

		/// <summary>
		/// Box 2b, Year
		/// </summary>
		[JsonPropertyName("carYear")]
		public int CarYear { get; set; }

		/// <summary>
		/// Box 2c, Make
		/// </summary>
		[JsonPropertyName("make")]
		public string Make { get; set; }

		/// <summary>
		/// Box 2d, Model
		/// </summary>
		[JsonPropertyName("model")]
		public string Model { get; set; }

		/// <summary>
		/// Box 3, Vehicle or other identification number
		/// </summary>
		[JsonPropertyName("vin")]
		public string Vin { get; set; }

		/// <summary>
		/// Box 4a, Donee certifies that vehicle was sold in arm's length transaction to unrelated party
		/// </summary>
		[JsonPropertyName("armsLengthTransaction")]
		public bool ArmsLengthTransaction { get; set; }

		/// <summary>
		/// Box 4b, Date of sale
		/// </summary>
		[JsonPropertyName("dateOfSale")]
		public DateTime DateOfSale { get; set; }

		/// <summary>
		/// Box 4c, Gross proceeds from sale (see instructions)
		/// </summary>
		[JsonPropertyName("grossProceeds")]
		public double GrossProceeds { get; set; }

		/// <summary>
		/// Box 5a, Donee certifies that vehicle will not be transferred for money, other property, or services before completion of material improvements or significant intervening use
		/// </summary>
		[JsonPropertyName("notTransferredBefore")]
		public bool NotTransferredBefore { get; set; }

		/// <summary>
		/// Box 5b, Donee certifies that vehicle is to be transferred to a needy individual for significantly below fair market value in furtherance of donee's charitable purpose
		/// </summary>
		[JsonPropertyName("needyIndividual")]
		public bool NeedyIndividual { get; set; }

		/// <summary>
		/// Box 5c, Donee certifies the following detailed description of material improvements or significant intervening use and duration of use
		/// </summary>
		[JsonPropertyName("descriptionOfImprovements")]
		public string DescriptionOfImprovements { get; set; }

		/// <summary>
		/// Box 6a, Did you provide goods or services in exchange for the vehicle? Yes
		/// </summary>
		[JsonPropertyName("goodsInExchange")]
		public bool GoodsInExchange { get; set; }

		/// <summary>
		/// Box 6b, Value of goods and services provided in exchange for the vehicle
		/// </summary>
		[JsonPropertyName("valueOfExchange")]
		public double ValueOfExchange { get; set; }

		/// <summary>
		/// Box 6c, If this box is checked, donee certifies that the goods and services consisted solely of intangible religious benefits
		/// </summary>
		[JsonPropertyName("intangibleReligious")]
		public bool IntangibleReligious { get; set; }

		/// <summary>
		/// Box 6c, Describe the goods and services, if any, that were provided
		/// </summary>
		[JsonPropertyName("descriptionOfGoods")]
		public string DescriptionOfGoods { get; set; }

		/// <summary>
		/// Box 7, Under the law, the donor may not claim a deduction of more than $500 for this vehicle if this box is checked
		/// </summary>
		[JsonPropertyName("maxDeductionApplies")]
		public bool MaxDeductionApplies { get; set; }
	}
}

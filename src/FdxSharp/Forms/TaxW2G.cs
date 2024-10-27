using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form W-2G, Certain Gambling Winnings
	/// </summary>
	public class TaxW2G : Tax
	{
		/// <summary>
		/// Payer's name, address and phone
		/// </summary>
		[JsonPropertyName("payerNameAddress")]
		public NameAddressPhone? PayerNameAddress { get; set; }

		/// <summary>
		/// PAYER'S federal identification number
		/// </summary>
		[JsonPropertyName("payerTin")]
		public string? PayerTin { get; set; }

		/// <summary>
		/// Winner's name and address
		/// </summary>
		[JsonPropertyName("winnerNameAddress")]
		public NameAddress? WinnerNameAddress { get; set; }

		/// <summary>
		/// Box 1, Reportable winnings
		/// </summary>
		[JsonPropertyName("winnings")]
		public double Winnings { get; set; }

		/// <summary>
		/// Box 2, Date won
		/// </summary>
		[JsonPropertyName("dateWon")]
		public DateTime? DateWon { get; set; }

		/// <summary>
		/// Box 3, Type of wager
		/// </summary>
		[JsonPropertyName("typeOfWager")]
		public string? TypeOfWager { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 5, Transaction
		/// </summary>
		[JsonPropertyName("transaction")]
		public string? Transaction { get; set; }

		/// <summary>
		/// Box 6, Race
		/// </summary>
		[JsonPropertyName("race")]
		public string? Race { get; set; }

		/// <summary>
		/// Box 7, Winnings from identical wagers
		/// </summary>
		[JsonPropertyName("identicalWinnings")]
		public double IdenticalWinnings { get; set; }

		/// <summary>
		/// Box 8, Cashier
		/// </summary>
		[JsonPropertyName("cashier")]
		public string? Cashier { get; set; }

		/// <summary>
		/// Box 9, Winner's taxpayer identification no.
		/// </summary>
		[JsonPropertyName("winnerTin")]
		public string? WinnerTin { get; set; }

		/// <summary>
		/// Box 10, Window
		/// </summary>
		[JsonPropertyName("window")]
		public string? Window { get; set; }

		/// <summary>
		/// Box 11, First I.D.
		/// </summary>
		[JsonPropertyName("firstId")]
		public string? FirstId { get; set; }

		/// <summary>
		/// Box 12, Second I.D.
		/// </summary>
		[JsonPropertyName("secondId")]
		public string? SecondId { get; set; }

		/// <summary>
		/// Box 13, State
		/// </summary>
		[JsonPropertyName("payerState")]
		public string? PayerState { get; set; }

		/// <summary>
		/// Box 14, State winnings
		/// </summary>
		[JsonPropertyName("stateWinnings")]
		public double StateWinnings { get; set; }

		/// <summary>
		/// Box 15, State income tax withheld
		/// </summary>
		[JsonPropertyName("stateTaxWithheld")]
		public double StateTaxWithheld { get; set; }

		/// <summary>
		/// Box 16, Local winnings
		/// </summary>
		[JsonPropertyName("localWinnings")]
		public double LocalWinnings { get; set; }

		/// <summary>
		/// Box 17, Local income tax withheld
		/// </summary>
		[JsonPropertyName("localTaxWithheld")]
		public double LocalTaxWithheld { get; set; }

		/// <summary>
		/// Box 18, Name of locality
		/// </summary>
		[JsonPropertyName("localityName")]
		public string? LocalityName { get; set; }

		/// <summary>
		/// Box 13, Payer's state identification no.
		/// </summary>
		[JsonPropertyName("payerStateId")]
		public string? PayerStateId { get; set; }
	}
}

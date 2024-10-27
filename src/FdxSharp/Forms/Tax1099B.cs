using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1099-B, Proceeds From Broker and Barter Exchange Transactions
	/// </summary>
	public class Tax1099B : Tax
	{
		/// <summary>
		/// Payer's name, address, and phone
		/// </summary>
		[JsonPropertyName("payerNameAddress")]
		public NameAddressPhone? PayerNameAddress { get; set; }

		/// <summary>
		/// Payer's federal identification number
		/// </summary>
		[JsonPropertyName("payerTin")]
		public string? PayerTin { get; set; }

		/// <summary>
		/// Recipient's identification number
		/// </summary>
		[JsonPropertyName("recipientTin")]
		public string? RecipientTin { get; set; }

		/// <summary>
		/// Recipient's name and address
		/// </summary>
		[JsonPropertyName("recipientNameAddress")]
		public NameAddress? RecipientNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Boxes 14-16, State tax withholding
		/// </summary>
		[JsonPropertyName("stateTaxWithholding")]
		public StateTaxWithholding[]? StateTaxWithholding { get; set; }

		/// <summary>
		/// Box 4, Federal income tax withheld
		/// </summary>
		[JsonPropertyName("federalTaxWithheld")]
		public double FederalTaxWithheld { get; set; }

		/// <summary>
		/// Box 8, Profit or (loss) realized in current year on closed contracts
		/// </summary>
		[JsonPropertyName("profitOnClosedContracts")]
		public double ProfitOnClosedContracts { get; set; }

		/// <summary>
		/// Box 9, Unrealized profit or loss on open contracts at end of last year
		/// </summary>
		[JsonPropertyName("unrealizedProfitOpenContractsBegin")]
		public double UnrealizedProfitOpenContractsBegin { get; set; }

		/// <summary>
		/// Box 10, Unrealized profit or loss on open contracts at end of current year
		/// </summary>
		[JsonPropertyName("unrealizedProfitOpenContractsEnd")]
		public double UnrealizedProfitOpenContractsEnd { get; set; }

		/// <summary>
		/// Box 11, Aggregate profit or (loss) on contracts
		/// </summary>
		[JsonPropertyName("aggregateProfitOnContracts")]
		public double AggregateProfitOnContracts { get; set; }

		/// <summary>
		/// Box 13, Bartering
		/// </summary>
		[JsonPropertyName("bartering")]
		public double Bartering { get; set; }

		/// <summary>
		/// Boxes 1-3, 5-7, 12, Security details
		/// </summary>
		[JsonPropertyName("securityDetails")]
		public SecurityDetail[]? SecurityDetails { get; set; }

		/// <summary>
		/// Second TIN Notice
		/// </summary>
		[JsonPropertyName("secondTinNotice")]
		public bool SecondTinNotice { get; set; }
	}
}

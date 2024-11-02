using System.Text.Json.Serialization;

namespace FdxSharp.Models
{
	/// <summary>
	/// Payment Details entity, Details of this payment
	/// </summary>
	public class PaymentDetails
	{
		/// <summary>
		/// The amount of payment applied to principal
		/// </summary>
		[JsonPropertyName("principalAmount")]
		public decimal PrincipalAmount { get; set; }

		/// <summary>
		/// The amount of payment applied to interest
		/// </summary>
		[JsonPropertyName("interestAmount")]
		public decimal InterestAmount { get; set; }

		/// <summary>
		/// The amount of payment applied to life/health/accident insurance on the loan
		/// </summary>
		[JsonPropertyName("insuranceAmount")]
		public decimal InsuranceAmount { get; set; }

		/// <summary>
		/// The amount of payment applied to escrow
		/// </summary>
		[JsonPropertyName("escrowAmount")]
		public decimal EscrowAmount { get; set; }

		/// <summary>
		/// The amount of payment applied to PMI
		/// </summary>
		[JsonPropertyName("pmiAmount")]
		public decimal PmiAmount { get; set; }

		/// <summary>
		/// The amount of payment applied to fees
		/// </summary>
		[JsonPropertyName("feesAmount")]
		public decimal FeesAmount { get; set; }
	}
}

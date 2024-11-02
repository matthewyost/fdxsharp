using System.Text.Json.Serialization;

#if NETSTANDARD2_0
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif

namespace FdxSharp.Forms
{
	/// <summary>
	/// Tax Refund Direct Deposit, IRS Form 8888 Direct Deposit Information
	/// </summary>
	public class TaxRefundDirectDeposit
	{
		/// <summary>
		/// Name of institution
		/// </summary>
		[JsonPropertyName("institutionName")]
		public string? InstitutionName { get; set; }

		/// <summary>
		/// Routing transit number
		/// </summary>
		[JsonPropertyName("rtn")]
		public string? Rtn { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Account nickname
		/// </summary>
		[JsonPropertyName("accountNickName")]
		public string? AccountNickName { get; set; }
	}
}

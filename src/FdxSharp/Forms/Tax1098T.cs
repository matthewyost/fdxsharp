using FdxSharp.Models;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1098-T, Tuition Statement
	/// </summary>
	public class Tax1098T : Tax
	{
		/// <summary>
		/// Filer's name, address, and phone
		/// </summary>
		[JsonPropertyName("filerNameAddress")]
		public NameAddressPhone? FilerNameAddress { get; set; }

		/// <summary>
		/// Filer's federal identification number
		/// </summary>
		[JsonPropertyName("filerTin")]
		public string? FilerTin { get; set; }

		/// <summary>
		/// Student's social security number
		/// </summary>
		[JsonPropertyName("studentTin")]
		public string? StudentTin { get; set; }

		/// <summary>
		/// By checking the box in STUDENT'S TIN, filer is making a true and accurate certification under penalty of perjury that they have complied with standards promulgated by the Secretary for obtaining such individual's TIN
		/// </summary>
		[JsonPropertyName("studentTinCertification")]
		public bool StudentTinCertification { get; set; }

		/// <summary>
		/// Student's name and address
		/// </summary>
		[JsonPropertyName("studentNameAddress")]
		public NameAddress? StudentNameAddress { get; set; }

		/// <summary>
		/// Account number
		/// </summary>
		[JsonPropertyName("accountNumber")]
		public string? AccountNumber { get; set; }

		/// <summary>
		/// Box 8, Check if at least half-time student
		/// </summary>
		[JsonPropertyName("halfTime")]
		public bool HalfTime { get; set; }

		/// <summary>
		/// Box 1, Payments received for qualified tuition and related expenses
		/// </summary>
		[JsonPropertyName("qualifiedTuitionFees")]
		public double QualifiedTuitionFees { get; set; }

		/// <summary>
		/// Box 4, Adjustments made for a prior year
		/// </summary>
		[JsonPropertyName("adjustmentPriorYear")]
		public double AdjustmentPriorYear { get; set; }

		/// <summary>
		/// Box 5, Scholarships or grants
		/// </summary>
		[JsonPropertyName("scholarship")]
		public double Scholarship { get; set; }

		/// <summary>
		/// Box 6, Adjustments to scholarships or grants for a prior year
		/// </summary>
		[JsonPropertyName("adjustScholarship")]
		public double AdjustScholarship { get; set; }

		/// <summary>
		/// Box 7, Check if the amount in box 1 or box 2 includes amounts for an academic period beginning January - March of next year
		/// </summary>
		[JsonPropertyName("includeJanMar")]
		public bool IncludeJanMar { get; set; }

		/// <summary>
		/// Box 9, Check if graduate student
		/// </summary>
		[JsonPropertyName("graduate")]
		public bool Graduate { get; set; }

		/// <summary>
		/// Box 10, Insurance contract reimbursement / refund
		/// </summary>
		[JsonPropertyName("insuranceRefund")]
		public double InsuranceRefund { get; set; }
	}
}

using System.Text.Json.Serialization;
using FdxSharp.Models;

namespace FdxSharp.Forms
{
    /// <summary>
    /// Form 1042-S, Foreign Person's U.S. Source Income Subject to Withholding
    /// </summary>
    public class Tax1042S : Tax
    {
        /// <summary>
        /// Unique form identifier.
        /// </summary>
        [JsonPropertyName("formId")]
        public string FormId { get; set; }

        /// <summary>
        /// Amended.
        /// </summary>
        [JsonPropertyName("amended")]
        public bool Amended { get; set; }

        /// <summary>
        /// Amendment number.
        /// </summary>
        [JsonPropertyName("amendmentNumber")]
        public int AmendmentNumber { get; set; }

        /// <summary>
        /// Box 1, Income code.
        /// </summary>
        [JsonPropertyName("incomeTypeCode")]
        public string IncomeTypeCode { get; set; }

        /// <summary>
        /// Box 2, Gross income.
        /// </summary>
        [JsonPropertyName("grossIncome")]
        public double GrossIncome { get; set; }

        /// <summary>
        /// Box 3, Chapter indicator.
        /// </summary>
        [JsonPropertyName("chapterIndicator")]
        public string ChapterIndicator { get; set; }

        /// <summary>
        /// Box 3a, Exemption code.
        /// </summary>
        [JsonPropertyName("ch3ExemptionCode")]
        public string Ch3ExemptionCode { get; set; }

        /// <summary>
        /// Box 3b, Tax rate.
        /// </summary>
        [JsonPropertyName("ch3TaxRate")]
        public double Ch3TaxRate { get; set; }

        /// <summary>
        /// Box 4a, Exemption code.
        /// </summary>
        [JsonPropertyName("ch4ExemptionCode")]
        public string Ch4ExemptionCode { get; set; }

        /// <summary>
        /// Box 4b, Tax rate.
        /// </summary>
        [JsonPropertyName("ch4TaxRate")]
        public double Ch4TaxRate { get; set; }

        /// <summary>
        /// Box 5, Withholding allowance.
        /// </summary>
        [JsonPropertyName("withholdingAllowance")]
        public double WithholdingAllowance { get; set; }

        /// <summary>
        /// Box 6, Net income.
        /// </summary>
        [JsonPropertyName("netIncome")]
        public double NetIncome { get; set; }

        /// <summary>
        /// Box 7a, Federal tax withheld.
        /// </summary>
        [JsonPropertyName("federalTaxWithheld")]
        public double FederalTaxWithheld { get; set; }

        /// <summary>
        /// Box 7b, Check if federal tax withheld was not deposited with the IRS because escrow procedures were applied.
        /// </summary>
        [JsonPropertyName("escrowProceduresApplied")]
        public bool EscrowProceduresApplied { get; set; }

        /// <summary>
        /// Box 7c, Check if withholding occurred in subsequent year with respect to a partnership interest.
        /// </summary>
        [JsonPropertyName("subsequentYear")]
        public bool SubsequentYear { get; set; }

        /// <summary>
        /// Box 8, Tax withheld by other agents.
        /// </summary>
        [JsonPropertyName("otherAgentsTaxWithheld")]
        public double OtherAgentsTaxWithheld { get; set; }

        /// <summary>
        /// Box 9, Overwithheld tax repaid to recipient pursuant to adjustment procedures.
        /// </summary>
        [JsonPropertyName("recipientRepaidAmount")]
        public double RecipientRepaidAmount { get; set; }

        /// <summary>
        /// Box 10, Total withholding credit.
        /// </summary>
        [JsonPropertyName("totalTaxWithholdingCredit")]
        public double TotalTaxWithholdingCredit { get; set; }

        /// <summary>
        /// Box 11, Tax paid by withholding agent (amounts not withheld).
        /// </summary>
        [JsonPropertyName("withholdingAgentTaxPaid")]
        public double WithholdingAgentTaxPaid { get; set; }

        /// <summary>
        /// Box 12, Withholding agent.
        /// </summary>
        [JsonPropertyName("withholdingAgent")]
        public Form1042Agent WithholdingAgent { get; set; }

        /// <summary>
        /// Box 13, Recipient.
        /// </summary>
        [JsonPropertyName("recipient")]
        public Form1042Recipient Recipient { get; set; }

        /// <summary>
        /// Box 13k, Recipient account number.
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Box 14, Primary Withholding Agent.
        /// </summary>
        [JsonPropertyName("primary")]
        public Form1042Agent Primary { get; set; }

        /// <summary>
        /// Box 15, Check if pro-rata basis reporting.
        /// </summary>
        [JsonPropertyName("prorataBasisReporting")]
        public bool ProrataBasisReporting { get; set; }

        /// <summary>
        /// Box 15, Intermediary or flow thru entity.
        /// </summary>
        [JsonPropertyName("intermediary")]
        public Form1042Agent Intermediary { get; set; }

        /// <summary>
        /// Box 16, Payer.
        /// </summary>
        [JsonPropertyName("payer")]
        public Form1042Agent Payer { get; set; }

        /// <summary>
        /// Box 17, State tax withholding.
        /// </summary>
        [JsonPropertyName("stateTaxWithholding")]
        public StateTaxWithholding StateTaxWithholding { get; set; }
    }
}

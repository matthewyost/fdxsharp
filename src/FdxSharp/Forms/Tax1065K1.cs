using FdxSharp.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FdxSharp.Forms
{
	/// <summary>
	/// Form 1065 K-1, Partner's Share of Income, Deductions, Credits, etc.
	/// </summary>
	public class Tax1065K1 : Tax
	{
		/// <summary>
		/// Fiscal year begin date.
		/// </summary>
		[JsonPropertyName("fiscalYearBegin")]
		public DateTime FiscalYearBegin { get; set; }

		/// <summary>
		/// Fiscal year end date.
		/// </summary>
		[JsonPropertyName("fiscalYearEnd")]
		public DateTime FiscalYearEnd { get; set; }

		/// <summary>
		/// Final K-1.
		/// </summary>
		[JsonPropertyName("finalK1")]
		public bool FinalK1 { get; set; }

		/// <summary>
		/// Amended K-1.
		/// </summary>
		[JsonPropertyName("amendedK1")]
		public bool AmendedK1 { get; set; }

		/// <summary>
		/// Box A, Partnership's employer identification number.
		/// </summary>
		[JsonPropertyName("partnershipTin")]
		public string PartnershipTin { get; set; }

		/// <summary>
		/// Box D, Partnership's name, address, city, state, and ZIP code.
		/// </summary>
		[JsonPropertyName("partnershipNameAddress")]
		public NameAddress PartnershipNameAddress { get; set; }

		/// <summary>
		/// Box C, IRS Center where partnership filed return.
		/// </summary>
		[JsonPropertyName("irsCenter")]
		public string IrsCenter { get; set; }

		/// <summary>
		/// Box D, Check if this is a publicly traded partnership (PTP).
		/// </summary>
		[JsonPropertyName("publiclyTraded")]
		public bool PubliclyTraded { get; set; }

		/// <summary>
		/// Box E, Partner's SSN or TIN.
		/// </summary>
		[JsonPropertyName("partnerTin")]
		public string PartnerTin { get; set; }

		/// <summary>
		/// Box F, Name, address, city, state, and ZIP code for partner entered in box E.
		/// </summary>
		[JsonPropertyName("partnerNameAddress")]
		public NameAddress PartnerNameAddress { get; set; }

		/// <summary>
		/// Box G, General partner or LLC member-manager.
		/// </summary>
		[JsonPropertyName("generalPartner")]
		public bool GeneralPartner { get; set; }

		/// <summary>
		/// Box G, Limited partner or other LLC member.
		/// </summary>
		[JsonPropertyName("limitedPartner")]
		public bool LimitedPartner { get; set; }

		/// <summary>
		/// Box H1, Domestic partner.
		/// </summary>
		[JsonPropertyName("domestic")]
		public bool Domestic { get; set; }

		/// <summary>
		/// Box H1, Foreign partner.
		/// </summary>
		[JsonPropertyName("foreign")]
		public bool Foreign { get; set; }

		/// <summary>
		/// Box H2, Check if the partner is a disregarded entity (DE), and enter the partner's TIN and Name.
		/// </summary>
		[JsonPropertyName("disregardedEntity")]
		public bool DisregardedEntity { get; set; }

		/// <summary>
		/// Box H2, Disregarded entity partner's TIN.
		/// </summary>
		[JsonPropertyName("disregardedEntityTin")]
		public string DisregardedEntityTin { get; set; }

		/// <summary>
		/// Box H2, Disregarded entity partner's Name.
		/// </summary>
		[JsonPropertyName("disregardedEntityName")]
		public string DisregardedEntityName { get; set; }

		/// <summary>
		/// Box I1, What type of entity is this partner?
		/// </summary>
		[JsonPropertyName("entityType")]
		public string EntityType { get; set; }

		/// <summary>
		/// Box I2, If this partner is a retirement plan (IRA/SEP/Keogh/etc.), check here.
		/// </summary>
		[JsonPropertyName("retirementPlan")]
		public bool RetirementPlan { get; set; }

		/// <summary>
		/// Box J, Partner's share of profit - beginning.
		/// </summary>
		[JsonPropertyName("profitShareBegin")]
		public double ProfitShareBegin { get; set; }

		/// <summary>
		/// Box J, Partner's share of profit - ending.
		/// </summary>
		[JsonPropertyName("profitShareEnd")]
		public double ProfitShareEnd { get; set; }

		/// <summary>
		/// Box J, Partner's share of loss - beginning.
		/// </summary>
		[JsonPropertyName("lossShareBegin")]
		public double LossShareBegin { get; set; }

		/// <summary>
		/// Box J, Partner's share of loss - ending.
		/// </summary>
		[JsonPropertyName("lossShareEnd")]
		public double LossShareEnd { get; set; }

		/// <summary>
		/// Box J, Partner's share of capital - beginning.
		/// </summary>
		[JsonPropertyName("capitalShareBegin")]
		public double CapitalShareBegin { get; set; }

		/// <summary>
		/// Box J, Partner's share of capital - ending.
		/// </summary>
		[JsonPropertyName("capitalShareEnd")]
		public double CapitalShareEnd { get; set; }

		/// <summary>
		/// Box J, Check if decrease is due to sale or exchange of partnership interest.
		/// </summary>
		[JsonPropertyName("decreaseDueToSaleOrExchange")]
		public bool DecreaseDueToSaleOrExchange { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - beginning - nonrecourse.
		/// </summary>
		[JsonPropertyName("nonrecourseLiabilityShareBegin")]
		public double NonrecourseLiabilityShareBegin { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - ending - nonrecourse.
		/// </summary>
		[JsonPropertyName("nonrecourseLiabilityShareEnd")]
		public double NonrecourseLiabilityShareEnd { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - beginning - qualified nonrecourse financing.
		/// </summary>
		[JsonPropertyName("qualifiedLiabilityShareBegin")]
		public double QualifiedLiabilityShareBegin { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - ending - qualified nonrecourse financing.
		/// </summary>
		[JsonPropertyName("qualifiedLiabilityShareEnd")]
		public double QualifiedLiabilityShareEnd { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - beginning - recourse.
		/// </summary>
		[JsonPropertyName("recourseLiabilityShareBegin")]
		public double RecourseLiabilityShareBegin { get; set; }

		/// <summary>
		/// Box K, Partner's share of liabilities - ending - recourse.
		/// </summary>
		[JsonPropertyName("recourseLiabilityShareEnd")]
		public double RecourseLiabilityShareEnd { get; set; }

		/// <summary>
		/// Box K, Check this box if item K includes liability amounts from lower tier partnerships.
		/// </summary>
		[JsonPropertyName("includesLowerTierLiability")]
		public bool IncludesLowerTierLiability { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Beginning capital account.
		/// </summary>
		[JsonPropertyName("capitalAccountBegin")]
		public double CapitalAccountBegin { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Capital contributed during the year.
		/// </summary>
		[JsonPropertyName("capitalAccountContributions")]
		public double CapitalAccountContributions { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Current year net income (loss).
		/// </summary>
		[JsonPropertyName("capitalAccountIncrease")]
		public double CapitalAccountIncrease { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Other increase (decrease).
		/// </summary>
		[JsonPropertyName("capitalAccountOther")]
		public double CapitalAccountOther { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Withdrawals &amp; distributions.
		/// </summary>
		[JsonPropertyName("capitalAccountWithdrawals")]
		public double CapitalAccountWithdrawals { get; set; }

		/// <summary>
		/// Box L, Partner's capital account analysis - Ending capital account.
		/// </summary>
		[JsonPropertyName("capitalAccountEnd")]
		public double CapitalAccountEnd { get; set; }

		/// <summary>
		/// Box M, Did the partner contribute property with a built-in gain or loss? - Yes.
		/// </summary>
		[JsonPropertyName("builtInGain")]
		public bool BuiltInGain { get; set; }

		/// <summary>
		/// Box N, Partner's Share of Net Unrecognized Section 704(c) Gain or (Loss) - beginning.
		/// </summary>
		[JsonPropertyName("unrecognizedSection704Begin")]
		public double UnrecognizedSection704Begin { get; set; }

		/// <summary>
		/// Box N, Partner's Share of Net Unrecognized Section 704(c) Gain or (Loss) - ending.
		/// </summary>
		[JsonPropertyName("unrecognizedSection704End")]
		public double UnrecognizedSection704End { get; set; }

		/// <summary>
		/// Box 1, Ordinary business income (loss).
		/// </summary>
		[JsonPropertyName("ordinaryIncome")]
		public double OrdinaryIncome { get; set; }

		/// <summary>
		/// Box 2, Net rental real estate income (loss).
		/// </summary>
		[JsonPropertyName("netRentalRealEstateIncome")]
		public double NetRentalRealEstateIncome { get; set; }

		/// <summary>
		/// Box 3, Other net rental income (loss).
		/// </summary>
		[JsonPropertyName("otherRentalIncome")]
		public double OtherRentalIncome { get; set; }

		/// <summary>
		/// Box 4a, Guaranteed payments for services.
		/// </summary>
		[JsonPropertyName("guaranteedPaymentServices")]
		public double GuaranteedPaymentServices { get; set; }

		/// <summary>
		/// Box 4b, Guaranteed payments for capital.
		/// </summary>
		[JsonPropertyName("guaranteedPaymentCapital")]
		public double GuaranteedPaymentCapital { get; set; }

		/// <summary>
		/// Box 4c, Total guaranteed payments.
		/// </summary>
		[JsonPropertyName("guaranteedPayment")]
		public double GuaranteedPayment { get; set; }

		/// <summary>
		/// Box 5, Interest income.
		/// </summary>
		[JsonPropertyName("interestIncome")]
		public double InterestIncome { get; set; }

		/// <summary>
		/// Box 6a, Ordinary dividends.
		/// </summary>
		[JsonPropertyName("ordinaryDividends")]
		public double OrdinaryDividends { get; set; }

		/// <summary>
		/// Box 6b, Qualified dividends.
		/// </summary>
		[JsonPropertyName("qualifiedDividends")]
		public double QualifiedDividends { get; set; }

		/// <summary>
		/// Box 6c, Dividend equivalents.
		/// </summary>
		[JsonPropertyName("dividendEquivalents")]
		public double DividendEquivalents { get; set; }

		/// <summary>
		/// Box 7, Royalties.
		/// </summary>
		[JsonPropertyName("royalties")]
		public double Royalties { get; set; }

		/// <summary>
		/// Box 8, Net short-term capital gain (loss).
		/// </summary>
		[JsonPropertyName("netShortTermGain")]
		public double NetShortTermGain { get; set; }

		/// <summary>
		/// Box 9a, Net long-term capital gain (loss).
		/// </summary>
		[JsonPropertyName("netLongTermGain")]
		public double NetLongTermGain { get; set; }

		/// <summary>
		/// Box 9b, Collectibles (28%) gain (loss).
		/// </summary>
		[JsonPropertyName("collectiblesGain")]
		public double CollectiblesGain { get; set; }

		/// <summary>
		/// Box 9c, Unrecaptured section 1250 gain.
		/// </summary>
		[JsonPropertyName("unrecaptured1250Gain")]
		public double Unrecaptured1250Gain { get; set; }

		/// <summary>
		/// Box 10, Net section 1231 gain (loss).
		/// </summary>
		[JsonPropertyName("net1231Gain")]
		public double Net1231Gain { get; set; }

		/// <summary>
		/// Box 11, Other income.
		/// </summary>
		[JsonPropertyName("otherIncome")]
		public List<CodeAmount> OtherIncome { get; set; }

		/// <summary>
		/// Box 12, Section 179 deduction.
		/// </summary>
		[JsonPropertyName("section179Deduction")]
		public double Section179Deduction { get; set; }

		/// <summary>
		/// Box 13, Other deductions.
		/// </summary>
		[JsonPropertyName("otherDeductions")]
		public List<CodeAmount> OtherDeductions { get; set; }

		/// <summary>
		/// Box 14, Self-employment earnings (loss).
		/// </summary>
		[JsonPropertyName("selfEmployment")]
		public List<CodeAmount> SelfEmployment { get; set; }

		/// <summary>
		/// Box 15, Credits.
		/// </summary>
		[JsonPropertyName("credits")]
		public List<CodeAmount> Credits { get; set; }

		/// <summary>
		/// Box 16, Schedule K-3 is attached.
		/// </summary>
		[JsonPropertyName("scheduleK3")]
		public bool ScheduleK3 { get; set; }

		/// <summary>
		/// Box 16, Foreign country. IRS deprecated 2021 and is now reported on Schedule K-3.
		/// </summary>
		[JsonPropertyName("foreignCountry")]
		public string ForeignCountry { get; set; }

		/// <summary>
		/// Box 16, Foreign transactions. IRS deprecated 2021 and is now reported on Schedule K-3.
		/// </summary>
		[JsonPropertyName("foreignTransactions")]
		public List<CodeAmount> ForeignTransactions { get; set; }

		/// <summary>
		/// Box 17, Alternative minimum tax (AMT) items.
		/// </summary>
		[JsonPropertyName("amtItems")]
		public List<CodeAmount> AmtItems { get; set; }

		/// <summary>
		/// Box 18, Tax-exempt income and nondeductible expenses.
		/// </summary>
		[JsonPropertyName("taxExemptIncome")]
		public List<CodeAmount> TaxExemptIncome { get; set; }

		/// <summary>
		/// Box 19, Distributions.
		/// </summary>
		[JsonPropertyName("distributions")]
		public List<CodeAmount> Distributions { get; set; }

		/// <summary>
		/// Box 20, Other information.
		/// </summary>
		[JsonPropertyName("otherInfo")]
		public List<CodeAmount> OtherInfo { get; set; }

		/// <summary>
		/// Box 21, Foreign taxes paid or accrued.
		/// </summary>
		[JsonPropertyName("foreignTaxPaid")]
		public double ForeignTaxPaid { get; set; }

		/// <summary>
		/// Box 22, More than one activity for at-risk purposes.
		/// </summary>
		[JsonPropertyName("multipleAtRiskActivities")]
		public bool MultipleAtRiskActivities { get; set; }

		/// <summary>
		/// Box 23, More than one activity for passive activity purposes.
		/// </summary>
		[JsonPropertyName("multiplePassiveActivities")]
		public bool MultiplePassiveActivities { get; set; }

	}
}

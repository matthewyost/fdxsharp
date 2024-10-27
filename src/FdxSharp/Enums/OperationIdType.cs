namespace FdxSharp.Enums
{
	/// <summary>
	/// Represents the operation ID types for various operations as per the FDX standard.
	/// </summary>
	public enum OperationIdType
	{
		cancelPayment,
		cancelRecurringPayment,
		cancelTransfer,
		createPayee,
		createTaxForm,
		deletePayee,
		getAccount,
		getAccountContact,
		getAccountPaymentNetworks,
		getAccountStatement,
		getAccountTransactionImages,
		getAvailability,
		getCapability,
		getCertificationMetrics,
		getConsentGrant,
		getCustomer,
		getCustomerInfo,
		getCustomers,
		getPayee,
		getPayment,
		getPaymentsForRecurringPayment,
		getRecurringPayment,
		getRewardProgram,
		getRewardProgramCategories,
		getTaxForm,
		getTransfer,
		getTransferStatus,
		reportSuspectedFraudIncident,
		requestAccountTransfer,
		schedulePayment,
		scheduleRecurringPayment,
		searchForAccountStatements,
		searchForAccountTransactions,
		searchForAccounts,
		searchForPayees,
		searchForPayments,
		searchForRecurringPayments,
		searchForTaxForms,
		searchForTransfers,
		searchRewardPrograms,
		updatePayee,
		updatePayment,
		updateRecurringPayment,
		updateTaxForm
	}

}

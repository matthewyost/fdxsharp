namespace FdxSharp.Enums
{
	/// <summary>
	/// Represents the operation ID types for various operations as per the FDX standard.
	/// </summary>
	public enum OperationIdType
	{
		/// <summary>Cancel a payment</summary>
		cancelPayment,
		/// <summary>Cancel a recurring payment</summary>
		cancelRecurringPayment,
		/// <summary>Cancel a transfer</summary>
		cancelTransfer,
		/// <summary>Create a payee</summary>
		createPayee,
		/// <summary>Create a tax form</summary>
		createTaxForm,
		/// <summary>Delete a payee</summary>
		deletePayee,
		/// <summary>Retrieve account information</summary>
		getAccount,
		/// <summary>Retrieve account contact information</summary>
		getAccountContact,
		/// <summary>Retrieve account payment networks</summary>
		getAccountPaymentNetworks,
		/// <summary>Retrieve account statement</summary>
		getAccountStatement,
		/// <summary>Retrieve images of account transactions</summary>
		getAccountTransactionImages,
		/// <summary>Check availability of services</summary>
		getAvailability,
		/// <summary>Retrieve capability information</summary>
		getCapability,
		/// <summary>Retrieve certification metrics</summary>
		getCertificationMetrics,
		/// <summary>Retrieve consent grant details</summary>
		getConsentGrant,
		/// <summary>Retrieve customer information</summary>
		getCustomer,
		/// <summary>Retrieve detailed customer information</summary>
		getCustomerInfo,
		/// <summary>Retrieve a list of customers</summary>
		getCustomers,
		/// <summary>Retrieve payee information</summary>
		getPayee,
		/// <summary>Retrieve payment information</summary>
		getPayment,
		/// <summary>Retrieve payments for a specific recurring payment</summary>
		getPaymentsForRecurringPayment,
		/// <summary>Retrieve information on a recurring payment</summary>
		getRecurringPayment,
		/// <summary>Retrieve reward program information</summary>
		getRewardProgram,
		/// <summary>Retrieve categories within a reward program</summary>
		getRewardProgramCategories,
		/// <summary>Retrieve a tax form</summary>
		getTaxForm,
		/// <summary>Retrieve transfer information</summary>
		getTransfer,
		/// <summary>Retrieve transfer status</summary>
		getTransferStatus,
		/// <summary>Report a suspected fraud incident</summary>
		reportSuspectedFraudIncident,
		/// <summary>Request an account transfer</summary>
		requestAccountTransfer,
		/// <summary>Schedule a payment</summary>
		schedulePayment,
		/// <summary>Schedule a recurring payment</summary>
		scheduleRecurringPayment,
		/// <summary>Search for account statements</summary>
		searchForAccountStatements,
		/// <summary>Search for account transactions</summary>
		searchForAccountTransactions,
		/// <summary>Search for accounts</summary>
		searchForAccounts,
		/// <summary>Search for payees</summary>
		searchForPayees,
		/// <summary>Search for payments</summary>
		searchForPayments,
		/// <summary>Search for recurring payments</summary>
		searchForRecurringPayments,
		/// <summary>Search for tax forms</summary>
		searchForTaxForms,
		/// <summary>Search for transfers</summary>
		searchForTransfers,
		/// <summary>Search for reward programs</summary>
		searchRewardPrograms,
		/// <summary>Update payee information</summary>
		updatePayee,
		/// <summary>Update payment information</summary>
		updatePayment,
		/// <summary>Update recurring payment information</summary>
		updateRecurringPayment,
		/// <summary>Update tax form information</summary>
		updateTaxForm
	}


}

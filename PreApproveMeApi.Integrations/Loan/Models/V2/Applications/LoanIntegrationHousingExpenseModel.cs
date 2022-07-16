using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    /// <summary>
    /// Housing expense details
    /// </summary>
    public class LoanIntegrationHousingExpenseModel
    {
        public bool? ProposedExpense { get; set; }
        public LoanIntegrationHousingExpenseType ExpenseType { get; set; }
        public decimal? MonthlyPayment { get; set; }

        /// <summary>
        /// ModelID of the loan associated with the housing expense.  This is used to represent e.g. a principal and interest payment for a related loan.
        /// </summary>
        public string AssociatedLoan { get; set; }
    }
}
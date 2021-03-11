using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationHousingExpenseModel
    {
        public bool? ProposedExpense { get; set; }
        public LoanIntegrationHousingExpenseType ExpenseType { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public string AssociatedLoan { get; set; }
    }
}
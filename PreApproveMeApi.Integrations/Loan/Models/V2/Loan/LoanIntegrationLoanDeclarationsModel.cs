using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationLoanDeclarationsModel
    {
        public bool? AZProvidedHUDForm { get; set; }
        public bool? AZCompletedDiscussion { get; set; }
        public bool? AZObtainedCreditReport { get; set; }
    }
}
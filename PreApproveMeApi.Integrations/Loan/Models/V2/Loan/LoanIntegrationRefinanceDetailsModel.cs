using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationRefinanceDetailsModel
    {
        public LoanIntegrationRefinancePurpose? RefinancePurpose { get; set; }
        public decimal? CashOut { get; set; }
    }
}
using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationInvestmentPropertyDetailsModel
    {
        public Types.LoanIntegrationRealEstateStatus? Disposition { get; set; }
    }
}
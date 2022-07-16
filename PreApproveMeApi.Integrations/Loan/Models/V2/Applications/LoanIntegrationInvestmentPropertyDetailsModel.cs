using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    /// <summary>
    /// REO extended details
    /// </summary>
    public class LoanIntegrationInvestmentPropertyDetailsModel
    {
        public LoanIntegrationRealEstateStatus? Disposition { get; set; }
    }
}
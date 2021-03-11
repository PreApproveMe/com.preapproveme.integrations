using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationConstructionDetailsModel
    {
        public int? YearBuilt { get; set; }
        public int? YearAcquired { get; set; }
        public decimal? OriginalCost { get; set; }
        public decimal? ImprovementsCost { get; set; }
        public bool? ExistingCleanEnergyLien { get; set; }
    }
}
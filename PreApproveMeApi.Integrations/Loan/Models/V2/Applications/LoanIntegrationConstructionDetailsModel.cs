using System;
using System.Collections.Generic;

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
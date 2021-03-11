using PreApproveMeApi.Integrations.Loan.Types.V2;

using System;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationMilitaryServiceModel
    {
        public bool? EligibleForVABenefits { get; set; }
        public bool? SpouseEligibleForVABenefits { get; set; }
        public LoanIntegrationMilitaryServiceType? ServiceType { get; set; }
        public DateTime? ServiceSeparationDate { get; set; }
    }
}
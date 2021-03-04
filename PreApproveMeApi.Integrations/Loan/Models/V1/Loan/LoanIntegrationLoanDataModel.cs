using PreApproveMeApi.Integrations.Loan.Types;

using System;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationLoanDataModel
    {
        public LoanIntegrationLoanPurpose? Purpose { get; set; }
        public DateTime? ClosingDate { get; set; }
        public LoanIntegrationQualificationType? QualificationType { get; set; }
        public LoanIntegrationConstructionRefinanceDataModel ConstructionRefinanceData { get; set; }
    }
}
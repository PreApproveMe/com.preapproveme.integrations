using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public sealed class LoanIntegrationBorrowerPairModel
    {
        public LoanIntegrationBorrowerModel PrimaryBorrower { get; set; }
        public List<LoanIntegrationBorrowerModel> CoBorrowers { get; set; }
    }
}
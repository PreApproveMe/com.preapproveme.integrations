using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationBorrowerUnitedStatesDataModel
    {
        public LoanIntegrationBorrowerUSDeclarationsModel Declarations { get; set; }
        public LoanIntegrationBorrowerUSFairHousingModel FairHousing { get; set; }
    }
}
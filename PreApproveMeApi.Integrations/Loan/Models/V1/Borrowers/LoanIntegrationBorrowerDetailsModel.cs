using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationBorrowerDetailsModel
    {
        public bool? Veteran { get; set; }
        public bool? FirstTimeHomeBuyer { get; set; }
    }
}
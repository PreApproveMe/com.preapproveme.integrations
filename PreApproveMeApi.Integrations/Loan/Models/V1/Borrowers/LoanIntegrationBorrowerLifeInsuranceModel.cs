using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationBorrowerLifeInsuranceModel
    {
        public string AccountNumber { get; set; }
        public decimal? RedemptionAmount { get; set; }
        public decimal? MarketValue { get; set; }
    }
}
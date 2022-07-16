using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationRefinanceDetailsModel
    {
        public LoanIntegrationRefinancePurpose? RefinancePurpose { get; set; }

        public decimal? CashOut { get; set; }
    }
}
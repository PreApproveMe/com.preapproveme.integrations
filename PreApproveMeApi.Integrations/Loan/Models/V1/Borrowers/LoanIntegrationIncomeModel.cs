using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationIncomeModel
    {
        public string Name { get; set; }
        public LoanIntegrationIncomeType Type { get; set; }
        public LoanIntegrationFrequencyType Period { get; set; }
        public decimal? Amount { get; set; }
    }
}
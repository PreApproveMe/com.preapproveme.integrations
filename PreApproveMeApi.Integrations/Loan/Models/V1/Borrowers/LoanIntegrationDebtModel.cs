using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationDebtModel : LoanIntegrationAddressModel
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public int? MonthsLeft { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? Balance { get; set; }
        public LoanIntegrationDebtType Type { get; set; }
    }
}
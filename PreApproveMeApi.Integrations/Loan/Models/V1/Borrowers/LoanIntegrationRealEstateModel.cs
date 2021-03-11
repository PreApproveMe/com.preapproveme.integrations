using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V1;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationRealEstateModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationRealEstateStatus? Status { get; set; }
        public LoanIntegrationRealEstateType? Type { get; set; }

        public decimal? MarketValue { get; set; }
        public decimal? OutstandingMortgagesLiens { get; set; }
        public decimal? GrossRentalIncome { get; set; }
        public decimal? MortgagePayments { get; set; }
        public decimal? OtherCosts { get; set; }
        public decimal? NetRentalIncome { get; set; }
    }
}
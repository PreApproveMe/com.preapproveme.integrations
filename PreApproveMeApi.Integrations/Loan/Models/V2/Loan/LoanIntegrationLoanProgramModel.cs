using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Details of the loan program
    /// </summary>
    public class LoanIntegrationLoanProgramModel
    {
        public string Name { get; set; }

        public LoanIntegrationProgramType Type { get; set; }

        public int TermMonths { get; set; }

        public LoanIntegrationAmortization Amortization { get; set; }

        public decimal? InterestRate { get; set; }

        public decimal? OriginationFees { get; set; }

        public decimal? ClosingCosts { get; set; }

        public LoanIntegrationValueModel MortgageInsurance { get; set; }

        public decimal? UpfrontMortgageInsurance { get; set; }

        public decimal? SellerContributions { get; set; }

        public decimal? MaximumDTI { get; set; }

        public decimal? MinimumDTI { get; set; }
    }
}
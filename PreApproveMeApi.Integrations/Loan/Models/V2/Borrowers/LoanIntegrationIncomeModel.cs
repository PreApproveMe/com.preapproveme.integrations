using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationIncomeModel
    {
        public decimal? AmountMonthly { get; set; }
        public string AssociatedEmployer { get; set; } // ID of employer this income is linked to, if any
        public LoanIntegrationIncomeType Type { get; set; }
        public string OtherDescription { get; set; }
        public bool? ForeignIncome { get; set; }
        public bool? SeasonalIncome { get; set; }
        //public bool? PresentIncome { get; set; } // This can be represented by being linked to an employer with an end date that is not null
    }
}
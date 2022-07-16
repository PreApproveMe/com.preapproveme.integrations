using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationIncomeModel
    {
        public decimal? AmountMonthly { get; set; }

        /// <summary>
        /// ModelID of the employer that this income is associated with, if any
        /// </summary>
        public string AssociatedEmployer { get; set; }

        public LoanIntegrationIncomeType Type { get; set; }

        public string OtherDescription { get; set; }

        public bool? ForeignIncome { get; set; }

        public bool? SeasonalIncome { get; set; }
    }
}
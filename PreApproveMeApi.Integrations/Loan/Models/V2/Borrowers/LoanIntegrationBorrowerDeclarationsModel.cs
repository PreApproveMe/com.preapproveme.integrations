using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationBorrowerDeclarationsModel
    {
        public bool? BankruptcyPastSevenYears { get; set; }
        public LoanIntegrationBankruptcyType? BankruptcyType { get; set; }
        public LoanIntegrationCitizenshipType? CitizenshipType { get; set; }
        public bool? PriorPropertyPastThreeYears { get; set; }
        public bool? SubjectPropertyWillBePrimaryResidence { get; set; }
        public Types.LoanIntegrationResidenceType? PriorPropertyUsageType { get; set; }
        public bool? PriorPropertyFHASecondaryResidence { get; set; }
        public Types.LoanIntegrationTitleType? PriorPropertyTitleType { get; set; }
        public bool? OutstandingJudgments { get; set; }
        public bool? PartyToLawsuit { get; set; }
        public bool? PresentlyDelinquent { get; set; }
        public bool? PriorPropertyDeedInLieu { get; set; }
        public bool? PriorPropertyForeclosureCompleted { get; set; }
        public bool? PriorPropertyShortSaleCompleted { get; set; }
        public bool? PropertyProposedCleanEnergyLien { get; set; }
        public bool? UndisclosedBorrowedFunds { get; set; }
        public decimal? UndisclosedBorrowedFundsAmount { get; set; }
        public bool? UndisclosedComakerOfNote { get; set; }
        public bool? UndisclosedCreditApplication { get; set; }
        public bool? UndisclosedMortgageApplication { get; set; }
        public bool? BorrowerSellerSpecialRelationship { get; set; }

        public bool? AZPropertySaleToQualify { get; set; }
        public bool? AZSellerConcessionsLoanCosts { get; set; }
        public bool? AZDownPaymentAssistance { get; set; }
    }
}
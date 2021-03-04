using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationBorrowerUSDeclarationsModel
    {
        public bool? OutstandingJudgements { get; set; }
        public bool? DeclaredBankrupt { get; set; }
        public bool? PropertyForeclosed { get; set; }
        public bool? PartyToLawsuit { get; set; }
        public bool? ObligatedForeclosure { get; set; }
        public bool? CurrentlyDelinquent { get; set; }
        public bool? PayingAlimony { get; set; }
        public bool? DownPaymentBorrowed { get; set; }
        public bool? ComakerEndorserNote { get; set; }
        public bool? USCitizen { get; set; }
        public bool? ResidentAlien { get; set; }
        public bool? WillUseForPrimaryResidence { get; set; }
        public bool? OwnedProperty { get; set; }
        public LoanIntegrationResidenceType? OwnedPropertyResidence { get; set; }
        public LoanIntegrationTitleType? OwnedPropertyTitle { get; set; }
    }
}
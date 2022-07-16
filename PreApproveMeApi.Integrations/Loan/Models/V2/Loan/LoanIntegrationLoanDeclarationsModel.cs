namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Declarations associated with the loan rather than an individual user or borrower.  Refer to the Arizona Association of Realtors forms.
    /// </summary>
    public class LoanIntegrationLoanDeclarationsModel
    {
        public bool? AZProvidedHUDForm { get; set; }
        public bool? AZCompletedDiscussion { get; set; }
        public bool? AZObtainedCreditReport { get; set; }
    }
}
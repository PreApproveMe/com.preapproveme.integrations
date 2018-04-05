namespace PreApproveMeApi.Integrations.Loan.Types
{
    public enum LoanIntegrationConditionStatus
    {
        WaitingBorrower = 1,
        WaitingServicer = 2,
        Accepted = 3,
        Rejected = 4
    }
}
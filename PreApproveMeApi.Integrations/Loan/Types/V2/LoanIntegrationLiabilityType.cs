namespace PreApproveMeApi.Integrations.Loan.Types.V2
{
    public enum LoanIntegrationLiabilityType
    {
        CollectionsJudgmentsAndLiens = 1,
        Installment = 2,
        LeasePayment = 3,
        Open30DayChargeAccount = 4,
        Other = 5,
        Revolving = 6,
        Taxes = 7,
        TaxLien = 8,
        Alimony = 9,
        ChildSupport = 10,
        JobRelatedExpenses = 11,
        SeparateMaintenanceExpense = 12,
        OtherExpense = 13
    }
}
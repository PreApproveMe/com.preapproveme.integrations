namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    /// <summary>
    /// Arizona specific declarations for the Arizona Prequal form.
    /// </summary>
    public class LoanIntegrationAZDeclarationsModel
    {
        public bool? BuyerPropertySaleToQualify { get; set; }
        public bool? BuyerSellerConcessionsLoanCosts { get; set; }
        public bool? BuyerDownPaymentAssistance { get; set; }
        public bool? LenderProvidedHUDForm { get; set; }
        public bool? LenderCompletedDiscussion { get; set; }
        public bool? LenderObtainedCreditReport { get; set; }
    }
}
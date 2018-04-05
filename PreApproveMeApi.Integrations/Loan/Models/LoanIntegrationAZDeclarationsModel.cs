namespace PreApproveMeApi.Integrations.Loan.Models
{
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
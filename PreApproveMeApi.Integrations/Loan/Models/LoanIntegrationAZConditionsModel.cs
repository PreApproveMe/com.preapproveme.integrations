namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationAZConditionsModel
    {
        public bool? Paystubs { get; set; }
        public bool? W2s { get; set; }
        public bool? PersonalTaxReturns { get; set; }
        public bool? CorporateTaxReturns { get; set; }
        public bool? DownPayment { get; set; }
        public bool? Gift { get; set; }
        public bool? CreditLiability { get; set; }
        public bool? Other { get; set; }
        public string OtherDescription { get; set; }
        public string AdditionalComments { get; set; }
    }
}
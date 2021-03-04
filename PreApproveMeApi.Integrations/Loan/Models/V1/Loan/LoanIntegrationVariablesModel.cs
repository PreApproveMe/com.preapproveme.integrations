using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationVariablesModel
    {
        public decimal? PurchasePrice { get; set; }
        public LoanIntegrationValueModel DownPayment { get; set; }
        public decimal? LoanAmount { get; set; }
        public LoanIntegrationValueModel HazardInsurance { get; set; }
        public LoanIntegrationValueModel HOADues { get; set; }
        public LoanIntegrationValueModel PropertyTaxes { get; set; }
    }
}
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    public class LoanIntegrationAddressDetailsModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationAddressType Type { get; set; }
        public LoanIntegrationResidenceOwnership? Ownership { get; set; }
        public int? Years { get; set; }
        public int? Months { get; set; }
    }
}
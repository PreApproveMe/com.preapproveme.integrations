using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V1;

namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    /// <summary>
    /// Residence details
    /// </summary>
    public class LoanIntegrationAddressDetailsModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationAddressType Type { get; set; }

        public LoanIntegrationResidenceOwnership? Ownership { get; set; }

        public int? Years { get; set; }

        public int? Months { get; set; }
    }
}
using PreApproveMeApi.Integrations.Loan.Types.V1;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationAssetModel : LoanIntegrationAddressModel
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public LoanIntegrationAssetType Type { get; set; }
        public decimal? Value { get; set; }
    }
}
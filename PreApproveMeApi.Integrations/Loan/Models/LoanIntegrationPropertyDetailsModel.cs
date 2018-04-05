using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationPropertyDetailsModel : LoanIntegrationAddressModel
    {
        public int? NumberOfUnits { get; set; }
        public int? YearBuilt { get; set; }
        public decimal? AppraisedValue { get; set; }
        public LoanIntegrationRealEstateType PropertyType { get; set; }
        public LoanIntegrationResidenceType? PropertyUse { get; set; }
    }
}
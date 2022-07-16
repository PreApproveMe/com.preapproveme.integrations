using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V1;

namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    /// <summary>
    /// Subject Property Details
    /// </summary>
    public class LoanIntegrationPropertyDetailsModel : LoanIntegrationAddressModel
    {
        public int? NumberOfUnits { get; set; }
        public int? YearBuilt { get; set; }
        public decimal? AppraisedValue { get; set; }
        public LoanIntegrationRealEstateType PropertyType { get; set; }
        public LoanIntegrationResidenceType? PropertyUse { get; set; }
    }
}
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    /// <summary>
    /// Representation of a loan application
    /// </summary>
    public class LoanIntegrationApplicationModel
    {
        public LoanIntegrationBorrowerModel PrimaryBorrower { get; set; }
        public List<LoanIntegrationBorrowerModel> CoBorrowers { get; set; }

        public List<LoanIntegrationAssetModel> Assets { get; set; }
        public List<LoanIntegrationLiabilityModel> Liabilities { get; set; }
        public List<LoanIntegrationPropertyModel> Properties { get; set; }
    }
}
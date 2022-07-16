using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Company associated with the loan, normally an origination company, but there is future support for other company types.
    /// </summary>
    public class LoanIntegrationCompanyModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationCompanyType CompanyType { get; set; }
        public List<string> ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string NMLS { get; set; }

        /// <summary>
        /// Point of contact
        /// </summary>
        public LoanIntegrationUserInfoModel Contact { get; set; }
    }
}
using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationCompanyModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationCompanyType CompanyType { get; set; }
        public List<string> ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string NMLS { get; set; }
        public LoanIntegrationUserInfoModel Contact { get; set; }
    }
}
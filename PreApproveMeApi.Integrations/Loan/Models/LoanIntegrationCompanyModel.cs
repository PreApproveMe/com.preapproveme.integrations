using System;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationCompanyModel : LoanIntegrationAddressModel
    {
        public string Name { get; set; }
        public string Domain { get; set; }
        public string NMLS { get; set; }
        public LoanIntegrationUserInfoModel Contact { get; set; }
    }
}
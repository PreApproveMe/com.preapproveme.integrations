using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationStaffModel
    {
        public LoanIntegrationUserInfoModel LoanOfficer { get; set; }
        public List<LoanIntegrationUserInfoModel> Processors { get; set; }
        public LoanIntegrationUserInfoModel BuyersAgent { get; set; }
        public LoanIntegrationUserInfoModel SellersAgent { get; set; }
        public List<LoanIntegrationUserInfoModel> Realtors { get; set; }
    }
}
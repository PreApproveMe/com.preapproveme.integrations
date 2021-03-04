using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationServicerModel
    {
        public LoanIntegrationUserInfoModel LoanOfficer { get; set; }
        public List<LoanIntegrationUserInfoModel> Processors { get; set; }
        public List<LoanIntegrationRealtorInfoModel> Realtors { get; set; }
    }
}
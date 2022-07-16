using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    /// <summary>
    /// Origination staff working on the loan
    /// </summary>
    public class LoanIntegrationServicerModel
    {
        public LoanIntegrationUserInfoModel LoanOfficer { get; set; }
        public List<LoanIntegrationUserInfoModel> Processors { get; set; }
        public List<LoanIntegrationRealtorInfoModel> Realtors { get; set; }
    }
}
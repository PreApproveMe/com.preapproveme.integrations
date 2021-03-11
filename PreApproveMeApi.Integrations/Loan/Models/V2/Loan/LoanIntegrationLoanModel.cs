using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationLoanModel
    {
        public long PamID { get; set; }
        public string ModelID { get; set; }
        public List<string> ReferenceNumber { get; set; }

        public LoanIntegrationLoanCategory Category { get; set; }
        public string Status { get; set; }

        public LoanIntegrationLoanType LoanType { get; set; }
        public LoanIntegrationLienType LienType { get; set; }
        public List<LoanIntegrationApplicationModel> Applications { get; set; }

        public LoanIntegrationCompanyModel OriginationCompany { get; set; }
        public LoanIntegrationStaffModel OriginationStaff { get; set; }
        public List<LoanIntegrationServicerModel> LoanServicers { get; set; }
        public LoanIntegrationLoanProgramModel Program { get; set; }
        public LoanIntegrationLoanTermsModel Terms { get; set; }
        public LoanIntegrationLoanDeclarationsModel Declarations { get; set; }
        public LoanIntegrationRefinanceDetailsModel RefinanceDetails { get; set; }

        public List<LoanIntegrationMilestoneModel> Milestones { get; set; }
        public List<LoanIntegrationConditionModel> Conditions { get; set; }

        public string ReferralInformation { get; set; }
        public string Notes { get; set; }

        // If milestones or conditions data has been updated as part of the request and these indicators are set then the system will send notifications to affected borrowers.
        public bool SendMilestoneNotifications { get; set; }
        public bool SendConditionNotifications { get; set; }
    }
}
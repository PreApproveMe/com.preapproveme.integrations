using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationLoanModel
    {
        public long? PamID { get; set; }
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }

        public LoanIntegrationServicerModel Servicers { get; set; }
        public LoanIntegrationVariablesModel Variables { get; set; }
        public LoanIntegrationLoanDataModel Data { get; set; }
        public LoanIntegrationLoanProgramModel Program { get; set; }
        public LoanIntegrationPropertyDetailsModel SubjectProperty { get; set; }
        public List<LoanIntegrationMilestoneModel> Milestones { get; set; }
        public List<LoanIntegrationConditionModel> Conditions { get; set; }

        public LoanIntegrationLoanCountryDataModel CountryData { get; set; }

        // If milestones or conditions data has been updated as part of the request and these indicators are set then the system will send notifications to affected borrowers.
        public bool? SendMilestoneNotifications { get; set; }
        public bool? SendConditionNotifications { get; set; }
    }
}
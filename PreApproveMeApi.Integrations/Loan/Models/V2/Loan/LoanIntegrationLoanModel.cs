using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationLoanModel
    {
        /// <summary>
        /// Internal PAM ID value of the loan
        /// </summary>
        public long PamID { get; set; }

        /// <summary>
        /// Identification string used to refer to this object by other links in the data structure.  This serves a similar purpose to Relationships in MISMO 3.4.
        /// </summary>
        public string ModelID { get; set; }

        /// <summary>
        /// Third party reference IDs
        /// </summary>
        public List<string> ReferenceNumber { get; set; }

        /// <summary>
        /// System category of the state of the loan
        /// </summary>
        public LoanIntegrationLoanCategory Category { get; set; }

        /// <summary>
        /// User defined loan status string
        /// </summary>
        public string Status { get; set; }

        public LoanIntegrationLoanType LoanType { get; set; }
        public LoanIntegrationLienType LienType { get; set; }

        /// <summary>
        /// Loan applications, similar to the BorrowerPairModel in V1
        /// </summary>
        public List<LoanIntegrationApplicationModel> Applications { get; set; }

        /// <summary>
        /// Company that owns the loan inside the system
        /// </summary>
        public LoanIntegrationCompanyModel OriginationCompany { get; set; }

        /// <summary>
        /// Users assoicated with the loan inside the system
        /// </summary>
        public LoanIntegrationStaffModel OriginationStaff { get; set; }

        /// <summary>
        /// Entities that service the loan post closing, generally will not be users in the system.
        /// </summary>
        public List<LoanIntegrationServicerModel> LoanServicers { get; set; }

        public LoanIntegrationLoanProgramModel Program { get; set; }
        public LoanIntegrationLoanTermsModel Terms { get; set; }

        /// <summary>
        /// Loan scope declarations, currently only used for Arizona.
        /// </summary>
        public LoanIntegrationLoanDeclarationsModel Declarations { get; set; }
        public LoanIntegrationRefinanceDetailsModel RefinanceDetails { get; set; }

        public List<LoanIntegrationMilestoneModel> Milestones { get; set; }
        public List<LoanIntegrationConditionModel> Conditions { get; set; }

        public string ReferralInformation { get; set; }
        public string Notes { get; set; }

        /// <summary>
        /// If milestones or conditions data has been updated as part of the request and these indicators are set then the system will send notifications to affected borrowers.
        /// Only used on import, ignored on export.
        /// </summary>
        public bool SendMilestoneNotifications { get; set; }
        public bool SendConditionNotifications { get; set; }
    }
}
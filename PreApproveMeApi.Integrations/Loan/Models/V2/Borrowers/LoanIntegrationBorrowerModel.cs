using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationBorrowerModel : LoanIntegrationUserInfoModel
    {
        /// <summary>
        /// ID of the borrower record in Pre-Approve Me
        /// </summary>
        public long PamID { get; set; }

        /// <summary>
        /// Internal model ID used to link e.g. assets to borrowers
        /// </summary>
        public string ModelID { get; set; }

        /// <summary>
        /// Third party reference number(s) set on the object
        /// </summary>
        public List<string> ReferenceID { get; set; }

        public List<LoanIntegrationEmployerModel> Employers { get; set; }
        public List<LoanIntegrationIncomeModel> Income { get; set; }
        public List<LoanIntegrationDependentModel> Dependents { get; set; }
        public LoanIntegrationBorrowerDeclarationsModel Declarations { get; set; }
        public LoanIntegrationGovernmentMonitoringModel Monitoring { get; set; }
        public LoanIntegrationMilitaryServiceModel MilitaryService { get; set; }

        public int? MonthsInCurrentProfession { get; set; }
        public string TPI { get; set; }
        public LoanIntegrationTaxpayerIdentifierType? TPIType { get; set; }
        public DateTime? Birthdate { get; set; }
        public LoanIntegrationMaritalStatus? MaritalStatus { get; set; }
        public DateTime? SignatureDate { get; set; }

        /// <summary>
        /// These indicators will trigger the onboarding process for a borrower if set as part of an import.
        /// </summary>
        public bool SendEmailInvitation { get; set; }
        public bool SendTextInvitation { get; set; }
    }
}
using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationBorrowerModel : LoanIntegrationUserInfoModel
    {
        public long PamID { get; set; }
        public string ModelID { get; set; }
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

        // These indicators will trigger the onboarding process for a borrower if set as part of an import.
        public bool SendEmailInvitation { get; set; }
        public bool SendTextInvitation { get; set; }
    }
}
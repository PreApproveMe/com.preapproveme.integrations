using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers;
using PreApproveMeApi.Integrations.Loan.Models.V1.Loan;

namespace PreApproveMeApi.Integrations.Loan
{
    [Description("1.0")]
    public sealed class LoanIntegrationModel_1_0 : LoanIntegrationBaseModel
    {
        public List<LoanIntegrationBorrowerPairModel> Borrowers { get; set; }
        public LoanIntegrationLoanModel Loan { get; set; }
        public LoanIntegrationCompanyModel Company { get; set; }
        // Not currently supported, provided for future compatability.
        public LoanIntegrationCompanyModel TitleInsurance { get; set; }
        // Servicer defined notes.
        public string Notes { get; set; }
        // Servicer defined notes.
        public string ReferralInformation { get; set; }

        // Deprecated
        public new const string ModelVersion = "1.0";
        public LoanIntegrationModel_1_0() { Version = ModelVersion; }
    }
}
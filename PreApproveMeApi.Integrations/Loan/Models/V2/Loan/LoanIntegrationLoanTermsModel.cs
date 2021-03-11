using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationLoanTermsModel
    {
        public decimal? PurchasePrice { get; set; }
        public LoanIntegrationValueModel DownPayment { get; set; }
        public decimal? LoanAmount { get; set; }
        public LoanIntegrationLoanPurpose? Purpose { get; set; }
        public DateTime? ClosingDate { get; set; }
        public LoanIntegrationQualificationType? QualificationType { get; set; }
    }
}
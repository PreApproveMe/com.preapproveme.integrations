using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V2.Applications;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Basic terms of the loan to be made, plus associated metadata
    /// </summary>
    public class LoanIntegrationLoanTermsModel
    {
        /// <summary>
        /// Alias for Estimated Value when loan is a refinance
        /// </summary>
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Alias for Equity when loan is a refinance
        /// </summary>
        public LoanIntegrationValueModel DownPayment { get; set; }

        /// <summary>
        /// Amount of the loan to be made
        /// </summary>
        public decimal? LoanAmount { get; set; }

        public LoanIntegrationLoanPurpose? Purpose { get; set; }

        public DateTime? ClosingDate { get; set; }

        public LoanIntegrationQualificationType? QualificationType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers;
using PreApproveMeApi.Integrations.Loan.Models.V1.Loan;

namespace PreApproveMeApi.Integrations.Loan
{
    /// <summary>
    /// Definition for the V1/Fannie 3.2 compatible model
    /// </summary>
    [Description("1.0")]
    public sealed class LoanIntegrationModel_1_0 : LoanIntegrationBaseModel
    {
        /// <summary>
        /// This is the list of loan applications that are contained within the loan.
        /// </summary>
        public List<LoanIntegrationBorrowerPairModel> Borrowers { get; set; }

        /// <summary>
        /// Container for main loan data such as loan amount, interest rate, milestones, conditions, etc.
        /// </summary>
        public LoanIntegrationLoanModel Loan { get; set; }

        /// <summary>
        /// Container for company data of the company that is originating the loan.
        /// </summary>
        public LoanIntegrationCompanyModel Company { get; set; }

        /// <summary>
        /// Not currently supported, provided for future compatability. 
        /// </summary>
        public LoanIntegrationCompanyModel TitleInsurance { get; set; }

        /// <summary>
        /// Loan Officer/Processor defined notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Loan Officer/Processor defined notes.
        /// </summary>
        public string ReferralInformation { get; set; }
    }
}
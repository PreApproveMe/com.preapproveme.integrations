using PreApproveMeApi.Integrations.Loan.Types;

using System;
using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Represents a condition that must be fulfilled to move the loan forward, most commonly some sort of documentation requested from the borrower.
    /// </summary>
    public class LoanIntegrationConditionModel
    {
        /// <summary>
        /// User facing name of the condition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Detailed description of the condition.
        /// </summary>
        public string Description { get; set; }

        public LoanIntegrationConditionStatus Status { get; set; }

        /// <summary>
        /// Intended completion date of the condition.  See status for the actual state of the condition.
        /// </summary>
        public DateTime? DueDate { get; set; }

        public List<string> ReferenceNumber { get; set; }

        /// <summary>
        /// List of emails of users assigned to complete this condition. Can be loan staff (e.g. a realtor) in addition to borrowers.
        /// </summary>
        public List<string> Assigned { get; set; }

        /// <summary>
        /// Links to files which have been attached to the loan.  Loan files will be in PDF format.
        /// </summary>
        public List<LoanIntegrationConditionFileModel> Files { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Represents a milestone, a significant event in the lifetime of the loan which can be used to show progress or trigger notifications.
    /// </summary>
    public class LoanIntegrationMilestoneModel
    {
        /// <summary>
        /// User-facing milestone name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Detailed Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// An incomplete milestone is indicated by a null value
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Display order when listing milestones in the UI
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Reference number for third party systems
        /// </summary>
        public List<string> ReferenceNumber { get; set; }

        /// <summary>
        /// Indicator for if the milestone is used for internal processes or tracking purposes rather than a milestone that should be borrower-facing.
        /// </summary>
        public bool? InternalMilestone { get; set; }
    }
}
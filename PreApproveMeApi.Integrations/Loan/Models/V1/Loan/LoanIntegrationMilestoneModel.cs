using System;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationMilestoneModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// UI display order of the milestone.
        /// </summary>
        public int? Order { get; set; }

        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Indicator for if the milestone is used for internal processes or tracking purposes rather than a milestone that should be borrower-facing.
        /// </summary>
        public bool? InternalMilestone { get; set; }
    }
}
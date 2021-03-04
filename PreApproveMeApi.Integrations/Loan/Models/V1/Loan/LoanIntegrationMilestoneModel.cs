using System;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationMilestoneModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        // UI display order of the milestone.
        public int? Order { get; set; }
        public string ReferenceNumber { get; set; }
        // Indicator for if the milestone is used for internal processes or tracking purposes rather than a milestone that should be borrower-facing.
        public bool? InternalMilestone { get; set; }
    }
}
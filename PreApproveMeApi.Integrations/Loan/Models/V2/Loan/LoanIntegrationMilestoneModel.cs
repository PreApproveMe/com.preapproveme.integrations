using System;
using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationMilestoneModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? DisplayOrder { get; set; }
        public List<string> ReferenceNumber { get; set; }
        // Indicator for if the milestone is used for internal processes or tracking purposes rather than a milestone that should be borrower-facing.
        public bool? InternalMilestone { get; set; }
    }
}
using PreApproveMeApi.Integrations.Loan.Types;

using System;
using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
{
    public class LoanIntegrationConditionModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public LoanIntegrationConditionStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
        public string ReferenceNumber { get; set; }
        // List of emails of users assigned to complete this condition.
        public List<string> Assigned { get; set; }
        public List<LoanIntegrationConditionFileModel> Files { get; set; }
    }
}
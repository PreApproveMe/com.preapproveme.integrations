using PreApproveMeApi.Integrations.Loan.Types;

using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationConditionFileModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // Pre-Approve Me stores all files in PDF format.
        // When importing, in order to ensure that the file is usable and viewable, it should be a PDF.
        // When exporting, the file exported will be a PDF.
        public string Link { get; set; }
        // Independent condition status for condition files will be coming in the conditions patch scheduled for Q1 2020.
        public LoanIntegrationConditionStatus Status { get; set; }
        public List<string> ReferenceNumber { get; set; }
    }
}
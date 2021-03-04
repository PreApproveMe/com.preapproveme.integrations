using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Loan
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
        public string ReferenceNumber { get; set; }
    }
}
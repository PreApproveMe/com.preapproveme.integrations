using PreApproveMeApi.Integrations.Loan.Types;

using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// File attached to a condition, most commonly one uploaded by a borrower.  Condition files should be treated securely since they often contain sensitive data.
    /// </summary>
    public class LoanIntegrationConditionFileModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Pre-Approve Me stores all files in PDF format.
        /// When importing, in order to ensure that the file is usable and viewable, it should be a PDF.
        /// When exporting, the file exported will be a PDF.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Files can have a status value independent of the underlying condition e.g. a first upload may be too blurry and a replacement is requested.
        /// </summary>
        public LoanIntegrationConditionStatus Status { get; set; }

        public List<string> ReferenceNumber { get; set; }
    }
}
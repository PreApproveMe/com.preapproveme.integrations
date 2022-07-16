using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    /// <summary>
    /// Model for attaching metadata to a scalar value
    /// </summary>
    public class LoanIntegrationValueModel
    {
        public LoanIntegrationValueType Type { get; set; }

        public LoanIntegrationFrequencyType Frequency { get; set; }

        public decimal? Value { get; set; }
    }
}
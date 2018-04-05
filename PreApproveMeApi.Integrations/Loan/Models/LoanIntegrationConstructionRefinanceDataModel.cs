using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationConstructionRefinanceDataModel
    {
        public int? YearAcquired { get; set; }
        public decimal? OriginalCost { get; set; }
        public decimal? AmountExistingLiens { get; set; }
        public decimal? PresentValueOfLot { get; set; }
        public decimal? CostOfImprovements { get; set; }
        public LoanIntegrationRefinancePurpose? RefinancePurpose { get; set; }
        public bool? ImprovementsPending { get; set; }
    }
}
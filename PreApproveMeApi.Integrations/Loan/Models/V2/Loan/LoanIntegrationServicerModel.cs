using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    public class LoanIntegrationServicerModel : LoanIntegrationUserInfoModel
    {
        public bool? IsCorporation { get; set; }
        public string CompanyName { get; set; }
        public bool? IsHELOC { get; set; }
        public LoanIntegrationPartyRoleType? PartyRole { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? TotalOwed { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Maximum { get; set; }
    }
}
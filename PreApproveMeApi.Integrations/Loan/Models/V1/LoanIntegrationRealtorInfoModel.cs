using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    public class LoanIntegrationRealtorInfoModel : LoanIntegrationUserInfoModel
    {
        public string CompanyName { get; set; }
    }
}
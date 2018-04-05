using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationRealtorInfoModel : LoanIntegrationUserInfoModel
    {
        public string CompanyName { get; set; }
    }
}
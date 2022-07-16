using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    /// <summary>
    /// Realtor-specific extended user information
    /// </summary>

    public class LoanIntegrationRealtorInfoModel : LoanIntegrationUserInfoModel
    {
        public string CompanyName { get; set; }
    }
}
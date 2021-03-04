using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationEmploymentModel
    {
        public int? CurrentProfessionYears { get; set; }
        public int? CurrentProfessionMonths { get; set; }
        public List<LoanIntegrationEmployerModel> Employers { get; set; }
    }
}
using PreApproveMeApi.Integrations.Loan.Types;

using System;
using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationEmployerModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationEmploymentStatus? Type { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// This maps to field 04B-130 in the Fannie 3.2 specification and will not be loaded as income.
        /// If you want to add this value as income then it should be additionally listed under the Income key on the Borrower model.
        /// </summary>

        public decimal? MonthlyIncome { get; set; }
    }
}
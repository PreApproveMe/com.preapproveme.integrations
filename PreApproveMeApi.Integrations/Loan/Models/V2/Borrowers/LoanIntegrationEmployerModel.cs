using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationEmployerModel : LoanIntegrationAddressModel
    {
        public string ModelID { get; set; }
        public Types.LoanIntegrationEmploymentStatus? Type { get; set; }
        public string EmployerName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        [Phone]
        public string ContactPhone { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
        public Types.V2.LoanIntegrationEmployerOwnershipInterest? OwnershipInterest { get; set; }

        public bool? EmployerIsPartyToTransaction { get; set; }
        public bool? PrimaryEmployer { get; set; }
        public bool? EmployerIsCorporation { get; set; }
    }
}
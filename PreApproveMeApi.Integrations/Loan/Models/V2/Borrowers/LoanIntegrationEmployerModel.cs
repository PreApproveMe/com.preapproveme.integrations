using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Types;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationEmployerModel : LoanIntegrationAddressModel
    {
        /// <summary>
        /// Internal ID used for linking incomes to employers
        /// </summary>
        public string ModelID { get; set; }

        public LoanIntegrationEmploymentStatus? Type { get; set; }

        public string EmployerName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string JobTitle { get; set; }

        [Phone]
        public string ContactPhone { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public LoanIntegrationEmployerOwnershipInterest? OwnershipInterest { get; set; }


        public bool? EmployerIsPartyToTransaction { get; set; }

        public bool? PrimaryEmployer { get; set; }

        public bool? EmployerIsCorporation { get; set; }
    }
}
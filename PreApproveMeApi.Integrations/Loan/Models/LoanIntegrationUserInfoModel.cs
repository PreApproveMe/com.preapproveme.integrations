﻿using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    public class LoanIntegrationUserInfoModel
    {
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Suffix { get; set; }

        // Email address is used as the primary identifier for user records in Pre-Approve Me.
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
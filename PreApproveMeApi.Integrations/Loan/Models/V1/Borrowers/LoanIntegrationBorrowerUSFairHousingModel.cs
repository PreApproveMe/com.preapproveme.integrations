﻿using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public class LoanIntegrationBorrowerUSFairHousingModel
    {
        public bool? OptIn { get; set; }
        public LoanIntegrationEthnicity? Race { get; set; }
        public LoanIntegrationGender? Gender { get; set; }
    }
}
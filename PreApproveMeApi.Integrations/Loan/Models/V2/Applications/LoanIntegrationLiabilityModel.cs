using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationLiabilityModel
    {
        public List<string> AssociatedBorrowers { get; set; }
        public LoanIntegrationLiabilityType? LiabilityType { get; set; }
        public string LiabilityTypeOtherDescription { get; set; }
        public string HolderName { get; set; }
        public string AccountNumber { get; set; }
        public int? MonthsLeft { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? UnpaidBalance { get; set; }
        public bool? PaidBeforeClosing { get; set; }
        public bool? HolderIsCorporation { get; set; }
    }
}
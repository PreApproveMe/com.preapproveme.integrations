using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationAssetModel
    {
        public List<string> AssociatedBorrowers { get; set; }
        public LoanIntegrationAssetType? AssetType { get; set; }
        public string AssetTypeOtherDescription { get; set; }
        public string FinancialInstitutionName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Value { get; set; }
        public bool? GiftDeposited { get; set; }
        public LoanIntegrationGiftSourceType? GiftSource { get; set; }
    }
}
using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    /// <summary>
    /// Asset or gift associated with one or more borrowers
    /// </summary>
    public class LoanIntegrationAssetModel
    {
        /// <summary>
        /// ModelID value(s) of the borrowers associated with the asset.
        /// </summary>
        public List<string> AssociatedBorrowers { get; set; }

        /// <summary>
        /// Asset or gift type
        /// </summary>
        public LoanIntegrationAssetType? AssetType { get; set; }

        public string AssetTypeOtherDescription { get; set; }

        public string FinancialInstitutionName { get; set; }

        public string AccountNumber { get; set; }

        public decimal? Value { get; set; }

        public bool? GiftDeposited { get; set; }

        public LoanIntegrationGiftSourceType? GiftSource { get; set; }
    }
}
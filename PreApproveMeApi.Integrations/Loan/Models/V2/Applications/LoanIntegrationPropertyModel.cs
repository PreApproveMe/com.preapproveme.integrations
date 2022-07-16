using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    /// <summary>
    /// Details of a property, e.g. the subject property or an REO associated with the loan
    /// </summary>
    public class LoanIntegrationPropertyModel : LoanIntegrationAddressModel
    {
        /// <summary>
        /// List of borrower(s) associated with the property.  Will contain ModelID values.
        /// </summary>
        public List<string> AssociatedBorrowers { get; set; }

        /// <summary>
        /// Type of the property, e.g. Subject Property, REO, Residence
        /// </summary>
        public LoanIntegrationPropertyType? Type { get; set; }

        public decimal? EstimatedValue { get; set; }
        public decimal? AssessedValue { get; set; }
        public decimal? NetRentalIncomeMonthly { get; set; }
        public decimal? GrossRentalIncomeMonthly { get; set; }
        public int? NumberOfUnits { get; set; }

        /// <summary>
        /// Expenses associated with the property
        /// </summary>
        public List<LoanIntegrationHousingExpenseModel> Expenses { get; set; }

        /// <summary>
        /// Extended values for residences
        /// </summary>
        public LoanIntegrationResidenceDetailsModel ResidenceDetails { get; set; }

        /// <summary>
        /// Extended values for REOs
        /// </summary>
        public LoanIntegrationInvestmentPropertyDetailsModel InvestmentDetails { get; set; }

        /// <summary>
        /// Extended values for Construction type loans
        /// </summary>
        public LoanIntegrationConstructionDetailsModel ConstructionDetails { get; set; }
    }
}
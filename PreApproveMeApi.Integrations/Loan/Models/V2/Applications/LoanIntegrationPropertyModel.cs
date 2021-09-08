using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationPropertyModel : LoanIntegrationAddressModel
    {
        public List<string> AssociatedBorrowers { get; set; }
        public LoanIntegrationPropertyType? Type { get; set; }
        public decimal? EstimatedValue { get; set; }
        public decimal? AssessedValue { get; set; }
        public decimal? NetRentalIncomeMonthly { get; set; }
        public decimal? GrossRentalIncomeMonthly { get; set; }
        public int? NumberOfUnits { get; set; }
        public List<LoanIntegrationHousingExpenseModel> Expenses { get; set; }
        public LoanIntegrationResidenceDetailsModel ResidenceDetails { get; set; }
        public LoanIntegrationInvestmentPropertyDetailsModel InvestmentDetails { get; set; }
        public LoanIntegrationConstructionDetailsModel ConstructionDetails { get; set; }
    }
}
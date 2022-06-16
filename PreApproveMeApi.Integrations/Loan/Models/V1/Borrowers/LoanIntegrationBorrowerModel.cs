using PreApproveMeApi.Integrations.Loan.Types;

using System;
using System.Collections.Generic;

namespace PreApproveMeApi.Integrations.Loan.Models.V1.Borrowers
{
    public sealed class LoanIntegrationBorrowerModel : LoanIntegrationUserInfoModel
    {
        public long? PamID { get; set; }
        public string SSN { get; set; }

        public string Nickname { get; set; }
        public int? YearsOfSchool { get; set; }
        public DateTime? Birthdate { get; set; }
        public LoanIntegrationMaritalStatus? MaritalStatus { get; set; }
        public DateTime? SignatureDate { get; set; }
        // Not currently supported, provided for future compatability.
        public int? FICOScore { get; set; }
        public bool? AssetsJointlyHeld { get; set; }

        public List<LoanIntegrationAddressDetailsModel> Addresses { get; set; }
        public LoanIntegrationEmploymentModel Employment { get; set; }
        public List<LoanIntegrationRealEstateModel> RealEstate { get; set; }
        public List<LoanIntegrationIncomeModel> Income { get; set; }
        public List<LoanIntegrationDebtModel> Debts { get; set; }
        public List<LoanIntegrationAssetModel> Assets { get; set; }
        public List<LoanIntegrationDependentModel> Dependents { get; set; }
        public LoanIntegrationBorrowerDetailsModel Details { get; set; }
        public List<LoanIntegrationBorrowerLifeInsuranceModel> LifeInsurance { get; set; }

        public LoanIntegrationBorrowerCountryDataModel CountryData { get; set; }

        // These indicators will trigger the onboarding process for a borrower if set as part of an import.
        public bool? SendEmailInvitation { get; set; }
        public bool? SendTextInvitation { get; set; }
    }
}
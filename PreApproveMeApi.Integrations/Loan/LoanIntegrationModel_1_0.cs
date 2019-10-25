using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Models;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan
{
    public sealed class LoanIntegrationModel_1_0 : LoanIntegrationBaseModel
    {
        public List<LoanIntegrationBorrowerPairModel> Borrowers { get; set; }
        public LoanIntegrationLoanModel Loan { get; set; }
        public LoanIntegrationCompanyModel Company { get; set; }
        public LoanIntegrationCompanyModel TitleInsurance { get; set; }
        public string Notes { get; set; }
        public string ReferralInformation { get; set; }

        public new const string ModelVersion = "1.0";
        public LoanIntegrationModel_1_0() { Version = ModelVersion; }
    }

    #region Borrowers

    public sealed class LoanIntegrationBorrowerPairModel
    {
        public LoanIntegrationBorrowerModel PrimaryBorrower { get; set; }
        public List<LoanIntegrationBorrowerModel> CoBorrowers { get; set; }
    }

    public sealed class LoanIntegrationBorrowerModel : LoanIntegrationUserInfoModel
    {
        public string SSN { get; set; }

        public string Nickname { get; set; }
        public int? YearsOfSchool { get; set; }
        public DateTime? Birthdate { get; set; }
        public LoanIntegrationMaritalStatus? MaritalStatus { get; set; }
        public DateTime? SignatureDate { get; set; }
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

        public bool SendEmailInvitation { get; set; }
        public bool SendTextInvitation { get; set; }
    }

    public class LoanIntegrationEmploymentModel
    {
        public int? CurrentProfessionYears { get; set; }
        public int? CurrentProfessionMonths { get; set; }
        public List<LoanIntegrationEmployerModel> Employers { get; set; }
    }

    public class LoanIntegrationEmployerModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationEmploymentStatus? Type { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        // This is listed for informational purposes only and will not be loaded as income
        public decimal? MonthlyIncome { get; set; }
    }

    public class LoanIntegrationRealEstateModel : LoanIntegrationAddressModel
    {
        public LoanIntegrationRealEstateStatus? Status { get; set; }
        public LoanIntegrationRealEstateType? Type { get; set; }

        public decimal? MarketValue { get; set; }
        public decimal? OutstandingMortgagesLiens { get; set; }
        public decimal? GrossRentalIncome { get; set; }
        public decimal? MortgagePayments { get; set; }
        public decimal? OtherCosts { get; set; }
        public decimal? NetRentalIncome { get; set; }
    }

    public class LoanIntegrationIncomeModel
    {
        public string Name { get; set; }
        public LoanIntegrationIncomeType Type { get; set; }
        public LoanIntegrationFrequencyType Period { get; set; }
        public decimal? Amount { get; set; }
    }

    public class LoanIntegrationAssetModel : LoanIntegrationAddressModel
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public LoanIntegrationAssetType Type { get; set; }
        public decimal? Value { get; set; }
    }

    public class LoanIntegrationDebtModel : LoanIntegrationAddressModel
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public int? MonthsLeft { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? Balance { get; set; }
        public LoanIntegrationDebtType Type { get; set; }
    }

    public class LoanIntegrationDependentModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }
    }

    public class LoanIntegrationBorrowerDetailsModel
    {
        public bool? Veteran { get; set; }
        public bool? FirstTimeHomeBuyer { get; set; }
    }

    public class LoanIntegrationBorrowerUSDeclarationsModel
    {
        public bool? OutstandingJudgements { get; set; }
        public bool? DeclaredBankrupt { get; set; }
        public bool? PropertyForeclosed { get; set; }
        public bool? PartyToLawsuit { get; set; }
        public bool? ObligatedForeclosure { get; set; }
        public bool? CurrentlyDelinquent { get; set; }
        public bool? PayingAlimony { get; set; }
        public bool? DownPaymentBorrowed { get; set; }
        public bool? ComakerEndorserNote { get; set; }
        public bool? USCitizen { get; set; }
        public bool? ResidentAlien { get; set; }
        public bool? WillUseForPrimaryResidence { get; set; }
        public bool? OwnedProperty { get; set; }
        public LoanIntegrationResidenceType? OwnedPropertyResidence { get; set; }
        public LoanIntegrationTitleType? OwnedPropertyTitle { get; set; }
    }

    public class LoanIntegrationBorrowerUSFairHousingModel
    {
        public bool? OptIn { get; set; }
        public LoanIntegrationEthnicity? Race { get; set; }
        public LoanIntegrationGender? Gender { get; set; }
    }

    public class LoanIntegrationBorrowerLifeInsuranceModel
    {
        public string AccountNumber { get; set; }
        public decimal? RedemptionAmount { get; set; }
        public decimal? MarketValue { get; set; }
    }

    public class LoanIntegrationBorrowerCountryDataModel
    {
        public LoanIntegrationBorrowerUnitedStatesDataModel UnitedStates { get; set; }
    }

    public class LoanIntegrationBorrowerUnitedStatesDataModel
    {
        public LoanIntegrationBorrowerUSDeclarationsModel Declarations { get; set; }
        public LoanIntegrationBorrowerUSFairHousingModel FairHousing { get; set; }
    }

    #endregion

    #region Loan

    public class LoanIntegrationLoanModel
    {
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }

        public LoanIntegrationServicerModel Servicers { get; set; }
        public LoanIntegrationVariablesModel Variables { get; set; }
        public LoanIntegrationLoanDataModel Data { get; set; }
        public LoanIntegrationLoanProgramModel Program { get; set; }
        public LoanIntegrationPropertyDetailsModel SubjectProperty { get; set; }
        public List<LoanIntegrationMilestoneModel> Milestones { get; set; }
        public List<LoanIntegrationConditionModel> Conditions { get; set; }

        public LoanIntegrationLoanCountryDataModel CountryData { get; set; }

        public bool SendMilestoneNotifications { get; set; }
        public bool SendConditionNotifications { get; set; }
    }

    public class LoanIntegrationServicerModel
    {
        public LoanIntegrationUserInfoModel LoanOfficer { get; set; }
        public List<LoanIntegrationUserInfoModel> Processors { get; set; }
        public List<LoanIntegrationRealtorInfoModel> Realtors { get; set; }
    }

    public class LoanIntegrationVariablesModel
    {
        public decimal? PurchasePrice { get; set; }
        public LoanIntegrationValueModel DownPayment { get; set; }
        public decimal? LoanAmount { get; set; }
        public LoanIntegrationValueModel HazardInsurance { get; set; }
        public LoanIntegrationValueModel HOADues { get; set; }
        public LoanIntegrationValueModel PropertyTaxes { get; set; }
    }

    public class LoanIntegrationLoanDataModel
    {
        public LoanIntegrationLoanPurpose? Purpose { get; set; }
        public DateTime? ClosingDate { get; set; }
        public LoanIntegrationQualificationType? QualificationType { get; set; }
        public LoanIntegrationConstructionRefinanceDataModel ConstructionRefinanceData { get; set; }
    }

    public class LoanIntegrationLoanProgramModel
    {
        public string Name { get; set; }
        public LoanIntegrationProgramType Type { get; set; }
        public int TermMonths { get; set; }
        public LoanIntegrationAmortization Amortization { get; set; }
        public decimal? InterestRate { get; set; }
        //public decimal? RateAdjustment { get; set; }
        public decimal? OriginationFees { get; set; }
        public decimal? ClosingCosts { get; set; }
        public LoanIntegrationValueModel MortgageInsurance { get; set; }
        public decimal? UpfrontMortgageInsurance { get; set; }
        public decimal? SellerContributions { get; set; }
        public decimal? MaximumDTI { get; set; }
        public decimal? MinimumDTI { get; set; }
    }

    public class LoanIntegrationMilestoneModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? Order { get; set; }
        public string ReferenceNumber { get; set; }
        public bool? InternalMilestone { get; set; }
    }

    public class LoanIntegrationConditionModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public LoanIntegrationConditionStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
        public string ReferenceNumber { get; set; }
        public List<string> Assigned { get; set; }
        public List<LoanIntegrationConditionFileModel> Files { get; set; }
    }

    public class LoanIntegrationConditionFileModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; } // Need to require that the file is a valid PDF
        public LoanIntegrationConditionStatus Status { get; set; } // Somewhat undefined until we get around to reworking conditions better
        public string ReferenceNumber { get; set; }
    }

    public class LoanIntegrationLoanCountryDataModel
    {
        public LoanIntegrationLoanUnitedStatesDataModel UnitedStates { get; set; }
    }

    public class LoanIntegrationLoanUnitedStatesDataModel
    {
        public LoanIntegrationAZDeclarationsModel AZDeclarations { get; set; }
        public LoanIntegrationAZConditionsModel AZConditions { get; set; }
    }

    #endregion
}
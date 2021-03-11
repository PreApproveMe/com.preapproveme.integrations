using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers
{
    public class LoanIntegrationGovernmentMonitoringModel
    {
        public bool? RefusedProvideEthnicity { get; set; }
        public bool? RefusedProvideGender { get; set; }
        public bool? RefusedProvideRace { get; set; }

        public bool? EthnicityBasedVisualOrName { get; set; }
        public bool? GenderBasedVisualOrName { get; set; }
        public bool? RaceBasedVisualOrName { get; set; }

        public LoanIntegrationHispanicEthnicityType? HispanicEthnicity { get; set; }
        public LoanIntegrationHispanicEthnicityOriginType? HispanicEthnicityOrigin { get; set; }
        public string HispanicEthnicityOriginOtherDescription { get; set; }

        public LoanIntegrationGenderType? Gender { get; set; }

        public LoanIntegrationRaceType? Race { get; set; }
        public LoanIntegrationRaceSubType? RaceSubType { get; set; }
        public string RaceDescription { get; set; }
        public string RaceSubTypeAsianDescription { get; set; }
        public string RaceSubTypePacificIslanderDescription { get; set; }
    }
}
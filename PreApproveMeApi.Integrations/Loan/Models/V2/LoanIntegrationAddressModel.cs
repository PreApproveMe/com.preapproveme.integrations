using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2
{
    public class LoanIntegrationAddressModel
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string LocalAdministrativeRegion { get; set; }
        public string RegionalAdministrativeRegion { get; set; }
        public LoanIntegrationGeneralAdministrativeRegionType? GeneralAdministrativeRegion { get; set; }
        public LoanIntegrationPropertyUnitType? UnitType { get; set; }

        // Aliases
        public string County
        {
            get
            {
                return LocalAdministrativeRegion;
            }
            set
            {
                LocalAdministrativeRegion = value;
            }
        }
        public string State
        {
            get
            {
                return RegionalAdministrativeRegion;
            }
            set
            {
                RegionalAdministrativeRegion = value;
            }
        }
        public LoanIntegrationGeneralAdministrativeRegionType? Country
        {
            get
            {
                return GeneralAdministrativeRegion;
            }
            set
            {
                GeneralAdministrativeRegion = value;
            }
        }
    }
}
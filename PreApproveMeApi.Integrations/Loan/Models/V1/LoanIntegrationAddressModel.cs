namespace PreApproveMeApi.Integrations.Loan.Models.V1
{
    public class LoanIntegrationAddressModel
    {
        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        /// <summary>
        /// Not currently supported, provided for future compatability.
        /// </summary>
        public string Country { get; set; }

        public string Zip { get; set; }
    }
}
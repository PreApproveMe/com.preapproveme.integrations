using System;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models.V1;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan.Models.V2.Applications
{
    public class LoanIntegrationResidenceDetailsModel
    {
        public DateTime? ResidenceStart { get; set; }
        public DateTime? ResidenceEnd { get; set; }
        public Types.LoanIntegrationResidenceType? Occupancy { get; set; }
        public Types.LoanIntegrationResidenceOwnership? Rental { get; set; }
        public LoanIntegrationConstructionMethodType? ConstructionMethod { get; set; }
        public bool? FHAQualifiedSecondaryResidence { get; set; }
        public bool? MixedUse { get; set; }
        public bool? ManufacturedHome { get; set; }
    }
}
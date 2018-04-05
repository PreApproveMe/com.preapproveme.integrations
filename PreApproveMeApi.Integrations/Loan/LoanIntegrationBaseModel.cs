using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan
{
    // Outstanding issues:
    // We should have some kind of indicator/tracking for tracking the source/destination of the integration and providing appropriate reference numbers
    // If we want to completely separate the contents of this namespace from the PreApproveMeApi namespace then the import and export functions will need to be moved elsewhere, either structured as extensions or put in a utilities file or moved to the data objects
    // For the LoanIntegrationBorrowerModel do we want to support multiple phones/emails?
    // Separate Y/M/D values rather than a single DateTime value
    // Address structure, currently we hold close to how addresses are represented in Fannie 3.2, but we could use a struct with named keys instead of a Type field

    /// <summary>
    /// The LoanIntegrationModel is the master model for communicating with external systems.
    /// It does not contain some of the lookups or tracking information that uses PAM internally, but provides a master format that any LOS system can use to integrate with PAM.
    /// </summary>
    public abstract class LoanIntegrationBaseModel
    {
        public const string ModelVersion = null;
        public string Version { get; set; }
    }
}
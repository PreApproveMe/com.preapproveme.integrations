using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

using PreApproveMeApi.Integrations.Loan.Models;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan
{
    /// <summary>
    /// The LoanIntegrationModel is the base model for communicating with external systems.
    /// All integration models must derive from this class.
    /// </summary>
    public class LoanIntegrationBaseModel
    {
        public string Version { get; set; }
    }
}
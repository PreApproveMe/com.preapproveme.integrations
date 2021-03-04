using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Models;
using PreApproveMeApi.Integrations.Loan.Types;

namespace PreApproveMeApi.Integrations.Loan
{
    [Description("3.4")]
    public sealed class LoanIntegrationModel_3_4 : LoanIntegrationBaseModel
    {
        // borrowers
            // employment
        // loan
            // variables
            // terms
            // program
        // multiple links as handled by relationships in 3.4, should have something similar
        // properties (have type as subject, reo, etc)
    }
}
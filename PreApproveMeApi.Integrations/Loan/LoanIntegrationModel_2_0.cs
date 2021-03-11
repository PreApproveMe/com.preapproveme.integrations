﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using PreApproveMeApi.Integrations.Loan.Models;
using PreApproveMeApi.Integrations.Loan.Models.V2.Borrowers;
using PreApproveMeApi.Integrations.Loan.Models.V2.Loan;
using PreApproveMeApi.Integrations.Loan.Types.V2;

namespace PreApproveMeApi.Integrations.Loan
{
    [Description("2.0")]
    public sealed class LoanIntegrationModel_2_0 : LoanIntegrationBaseModel
    {
        public List<LoanIntegrationLoanModel> Loans { get; set; }
    }
}
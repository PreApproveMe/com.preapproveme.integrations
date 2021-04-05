using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreApproveMeApi.Integrations.Loan.Types.V2
{
    public enum LoanIntegrationPartyRoleType
    {
        SubmittingParty,
        Borrower,
        NotePayTo,
        LoanOriginationCompany,
        LoanOriginator,
        PropertyOwner,
        Trust,
        HousingCounselingAgency
    }
}

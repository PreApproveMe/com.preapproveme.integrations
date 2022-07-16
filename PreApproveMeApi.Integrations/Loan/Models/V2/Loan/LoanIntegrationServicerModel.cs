namespace PreApproveMeApi.Integrations.Loan.Models.V2.Loan
{
    /// <summary>
    /// Entity that services payments on the loan post-closing
    /// </summary>
    public class LoanIntegrationServicerModel : LoanIntegrationUserInfoModel
    {
        public bool? IsCorporation { get; set; }
    }
}
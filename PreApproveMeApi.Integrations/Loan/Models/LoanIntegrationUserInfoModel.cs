using System.ComponentModel.DataAnnotations;

namespace PreApproveMeApi.Integrations.Loan.Models
{
    /// <summary>
    /// Representation of a user in the system
    /// </summary>
    public class LoanIntegrationUserInfoModel
    {
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Suffix { get; set; }

        /// <summary>
        /// Email address is used as the primary identifier for user records in Pre-Approve Me.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// This is generally understood to be a mobile phone in Pre-Approve Me.
        /// </summary>
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
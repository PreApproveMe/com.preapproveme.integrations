namespace PreApproveMeApi.Integrations.User
{
    public class UserIntegrationBaseModel
    {
        public UserIntegrationModel InitiatingUser { get; set; }
        public UserIntegrationModel TargetUser { get; set; }
        public UserIntegrationModel AssociatedUser { get; set; }
        public UserIntegrationDataModel Data { get; set; }
    }

    public class UserIntegrationModel
    {
        public long UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}

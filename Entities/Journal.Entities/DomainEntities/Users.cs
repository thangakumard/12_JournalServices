namespace Journal.Entities.DomainEntities
{
    public class Users
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string EmailID { get; set; }

        public string Mobile { get; set; }

        public bool IsActive { get; set; }
    }
}

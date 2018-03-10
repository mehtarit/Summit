namespace Summit.API.Models
{
    public class RegistrationRequest
    {
        public string Username { get; set; }
        public string Region { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferedName { get; set; }
        public bool IsGraduate { get; set; }
        public bool IsITDP { get; set; }
        public bool IsLeader { get; set; }
        public bool IsITLP { get; set; }
        public bool IsCioPeople { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TShirtSize { get; set; }

    }
}

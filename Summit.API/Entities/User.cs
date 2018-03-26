using System;
using System.ComponentModel.DataAnnotations;
using Summit.API.Enums;

namespace Summit.API.Entities
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public Region Region { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public bool IsGraduate { get; set; }
        public bool IsITDP { get; set; }
        public bool IsLeader { get; set; }
        public bool IsITLP { get; set; }
        public bool IsCioPeople { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateModified { get; set; }
        public City? City { get; set; }
        public Country? Country { get; set; }
        public TshirtSize? TShirtSize { get; set; }
    }
}

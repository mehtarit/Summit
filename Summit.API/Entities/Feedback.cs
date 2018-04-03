using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Summit.API.Enums;

namespace Summit.API.Entities
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SessionName { get; set; }

        public int SessionId { get; set; }

        public string UserName { get; set; }

        public Region Region { get; set; }

        public string Review { get; set; }

        public DateTime DateModified { get; set; }

        public int Rating { get; set; }
    }
}

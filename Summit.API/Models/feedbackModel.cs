using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Summit.API.Models
{
    public class feedbackModel
    {
        [Required]
        public string Email { get; set; }
        public string feedbackk { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Summit.API.Models
{
    public class feedbackModel
    {

        public string Session { get; set; }
        public string feedbackk { get; set; }
        public string country { get; set; }
        public string rating { get; set; }
    }
}

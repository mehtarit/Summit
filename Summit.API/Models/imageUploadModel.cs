using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Summit.API.Models
{
    public class imageUploadModel
    {

        [Required]

        public string filepath { get; set; }

        public string targetURL { get; set; }
        public string downloadURL { get; set; }
    }
}

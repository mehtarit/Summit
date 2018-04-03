using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using Summit.API.Enums;
using Swashbuckle.AspNetCore.Swagger;

namespace Summit.API.Models
{
    public class FeedbackRequest
    {
        public string SessionName { get; set; }

        public int SessionId { get; set; }

        public string UserName { get; set; }

        public string Region { get; set; }
        
        public string Feedback { get; set; }

        [Range(1,10)]
        public int Rating { get; set; }

    }
}

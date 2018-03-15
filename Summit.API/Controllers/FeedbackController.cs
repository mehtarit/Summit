using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Summit.API.Models;

namespace Summit.API.Controllers
{
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {

        // POST api/Feedback

        [HttpPost]
        public void Post([FromBody]feedbackModel model)
        {

            string country = model.country;
            if (model.country==null)
            {
                country = "Austin";
            }
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                session = model.Session,
                review = model.feedbackk,
                rating = model.rating
            });
            var request = WebRequest.CreateHttp("https://annualsumm.firebaseio.com/Feedback/" + country + ".json");
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using Firebase.Storage;
using System.IO;
using Firebase.Storage;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text;
using Summit.API.Models;

namespace Summit.API.Controllers
{

    [Route("api/[controller]")]
    public class ImageUploadController : Controller
    {




        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //POST api/Images
        [HttpPost]
        public string Post(imageUploadModel model)
        {
            var stream = System.IO.File.Open(model.filepath, FileMode.Open);         
            Random random = new Random();
            int number = random.Next(50);
            var name = RandomString(number);
            name = name + ".png";

            var task = new FirebaseStorage("annualsumm.appspot.com")
             .Child("data")
             .Child("summit")
             .Child(name)     
             .PutAsync(stream);

            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
            var downloadUrl = task;  
            var targetURL = task.TargetUrl; //save this somewhere and use it to get the download link
            model.targetURL = targetURL;
            return targetURL;
        }



        


    }
}
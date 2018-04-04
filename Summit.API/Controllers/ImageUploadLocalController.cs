using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Summit.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using Firebase.Storage;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text;


namespace Summit.API.Controllers
{
    [Route("api/[controller]")]
    public class ImageUploadLocalController : Controller
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
    public string Post()
    {
            try
            {
                ImageUploadLocal model = new ImageUploadLocal();
                long size = 0;
                var files = Request.Form.Files;
                foreach (var file in files)
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(
                       Directory.GetCurrentDirectory(), "UploadedFiles",
                       filename);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        return "upload successful";
                    }
                }


                return "Upload Successful";
            }
            
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
    }


    }

}
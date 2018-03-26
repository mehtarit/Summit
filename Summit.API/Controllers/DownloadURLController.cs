using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    public class DownloadURLController : Controller
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }





        [HttpPost]
        public string Post([FromBody]imageUploadModel model)
        {
            try {
                string output;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(model.targetURL);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    output = reader.ReadToEnd();
                }
                JObject json = JObject.Parse(output);
                string name = (string)json.SelectToken("name");
                name = name.Replace("/", "%2F");
                string token = (string)json.SelectToken("downloadTokens");


                string downloadURL = "https://firebasestorage.googleapis.com/v0/b/annualsumm.appspot.com/o/" + name + "?alt=media&token=" + token;

                model.downloadURL = downloadURL;
                return downloadURL;
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }



    }
}
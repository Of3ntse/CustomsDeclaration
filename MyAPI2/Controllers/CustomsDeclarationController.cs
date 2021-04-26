using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomsDeclaration.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace CustomsDeclaration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomsDeclarationController : ControllerBase
    {
        String url = "https://ecustoms-tst.burs.org.bw/TFBSEW/cusLogin/courierservice/declaration";

        private IConfiguration configuration;

        public CustomsDeclarationController(IConfiguration iconfig)
        {
            configuration = iconfig;
        }

        [HttpPost("/api/customs/declarationenquiry")]
        public async Task<ActionResult<CustomsDeclarationResponse>> PostDeclaration([FromBody] CustomsDeclarationRequest customsDeclarationRequest)
       // public async Task<CustomsDeclarationResponse> PostDeclaration([FromBody] CustomsDeclarationRequest customsDeclarationRequest)
        {
            // HttpContent content = new StringContent(JsonConvert.SerializeObject(customsDeclarationRequest),
            // Encoding.UTF8, "application/json");

            var jsonrequestMessage = JsonConvert.SerializeObject(customsDeclarationRequest);

            var customsUrl = configuration.GetValue<string>("CustomsEndPoint");
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            byte[] byteArray = Encoding.UTF8.GetBytes(jsonrequestMessage.ToString());
            httpWebRequest.ContentLength = byteArray.Length;

            Stream dataStream = httpWebRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //var data = JsonConvert.DeserializeObject<CustomsDeclarationResponse>(httpResponse.ToString());
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
               
                var result = streamReader.ReadToEnd();
                //var myUser = JsonConvert.DeserializeObject(result);
                String responseresult = result.ToString();
                return JsonConvert.DeserializeObject<CustomsDeclarationResponse>(result); 
            }

            if (httpResponse.StatusDescription != "OK")
            {
                throw new Exception("HTTP Error: " + httpResponse.StatusCode + " " + httpResponse.StatusDescription);
            }
            
        }

    }
}

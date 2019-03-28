using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Craps.DataModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Craps.ApiDataHandlers
{
    public class RollDataHandler
    {
        private static HttpClient client;

        public RollDataHandler()
        {

            var proxy = new WebProxy()
            {
                Address = new Uri($"{"http://wpad.stab.corp.local/wpad-us.dat"}:{8083}"),
                UseDefaultCredentials = true,

            };

            // Now create a client handler which uses that proxy

            var httpClientHandler = new HttpClientHandler() {Proxy = proxy};

        client = new HttpClient(httpClientHandler);

        }

        public async Task<RollDataModel> GetRoll()
        {
            try
            {
                var stringTask = client.GetAsync("Https://rolz.org/api/?1d6.json");//client.GetStringAsync("https://rolz.org/api/?1d6.json");

                HttpResponseMessage result = await stringTask;

                var jsonString = result.Content.ToString();

                RollDataModel output = JsonConvert.DeserializeObject<RollDataModel>(jsonString);

                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}

﻿using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Craps.DataModels;
using Newtonsoft.Json;

namespace Craps.ApiDataHandlers
{
    public class RollDataHandler
    {
        private static HttpClient client;

        public RollDataHandler()
        {                 

            // Now create a client handler which uses that proxy

            var httpClientHandler = new HttpClientHandler();

            client = new HttpClient(httpClientHandler);

        }

        public async Task<RollDataModel> GetRoll()
        {
            try
            {
                var stringTask = client.GetStringAsync("Https://rolz.org/api/?1d6.json");//client.GetStringAsync("https://rolz.org/api/?1d6.json");
                
                var jsonString = await stringTask;//result.Content.ReadAsFormDataAsync();

                RollDataModel output = JsonConvert.DeserializeObject<RollDataModel>(jsonString.ToString());

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

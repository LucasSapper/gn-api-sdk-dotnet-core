using System;
using System.IO;
using Gerencianet.NETStardard.SDK;
using Newtonsoft.Json.Linq;

namespace Gerencianet.NETCore.SDK.Examples
{
    class PixDetailWebhook
    {
        public static void Execute()
        {
            dynamic endpoints =  new Endpoints(JObject.Parse (File.ReadAllText ("credentials.json")));
                
            var param = new {
                chave = "71cdf9ba-c695-4e3c-b010-abb521a3f1be"
            };

            try {
                var response = endpoints.PixDetailWebhook(param);
                Console.WriteLine(response);
            } catch (GnException e) {
                Console.WriteLine(e.ErrorType);
                Console.WriteLine(e.Message);
            }

        }
    }
}
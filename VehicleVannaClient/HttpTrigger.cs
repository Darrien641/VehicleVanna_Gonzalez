using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace VehicleVannaClient
{
    class HttpTrigger
    {
        public static async Task HttpResponse(Vehicle v)
        {
            string url = "http://localhost:7071/api/Function1";
            var client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url, v);
        }
    }
}

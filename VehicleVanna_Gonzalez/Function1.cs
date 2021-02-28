using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace VehicleVanna_Gonzalez
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Queue("VehicleQueue")] IAsyncCollector<Vehicle> VehicleOrders,
            ILogger log)

        {
            decimal discountPrice;
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var Order = JsonConvert.DeserializeObject<Vehicle>(requestBody);
            await VehicleOrders.AddAsync(Order);
            discountPrice = Order.ListPrice * .085m;
            log.LogInformation($"Buyer {Order.FirstName} {Order.LastName} ({Order.Email})" +
                $" purchased a {Order.Year} {Order.Make} {Order.Model} {Order.VehicleType_.ToString()}\n" +
                $" with a list price of {Order.ListPrice}. With discount applied, purchase price is {(Order.ListPrice - discountPrice)}");

            string responseMessage = $"Buyer {Order.FirstName} {Order.LastName} ({Order.Email})" +
                $" purchased a {Order.Year} {Order.Year} {Order.Make} {Order.VehicleType_.ToString()}" +
                $"with a list price of ${Order.ListPrice}. With discount applied, purchase price is ${(Order.ListPrice - discountPrice)}";

            return new OkObjectResult(responseMessage);
        }
   
    }
}

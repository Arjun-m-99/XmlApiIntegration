using Microsoft.AspNetCore.Mvc;
//using RezLiveApis.Models;
using System.Net;


using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace RezLiveApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet(Name = "getCustomerDetails")]
        //public IActionResult Index()
        //{
        //    //    //Setting TLS 1.2 protocol
        //    //    ServicePointManager.Expect100Continue = true;
        //    //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        //    //    //Fetch the JSON string from URL.
        //    List<CustomerModel> customers = new List<CustomerModel>();
        //    string apiUrl = "https://raw.githubusercontent.com/aspsnippets/test/master/Customers.json";

        //    HttpClient client = new HttpClient();
        //    HttpResponseMessage response = client.GetAsync(apiUrl).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        customers = JsonConvert.DeserializeObject<List<CustomerModel>>(response.Content.ReadAsStringAsync().Result);
        //    }

        //    //    //Return the Deserialized JSON object.
        //    return Ok(customers);
        //}
    }
}
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using RezLiveApis.Interfaces;
//using RezLiveApis.Models;

//namespace RezLiveApis.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HomeController : ControllerBase
//    {
//        private readonly IHolidaysApiService _holidaysApiService;
//        public HomeController(IHolidaysApiService holidaysApiService)
//        {
//            _holidaysApiService = holidaysApiService;
//        }

//        public async Task<IActionResult> Index(string countryCode, int year)
//        {
//            List<HolidayModel> holidays = new List<HolidayModel>();
//            holidays = await _holidaysApiService.GetHolidays(countryCode, year);

//            return Ok(holidays);
//        }
//    }
//}

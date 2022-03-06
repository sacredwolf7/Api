using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Controller]
    public class WeatherForecastController : Controller
    {
        [HttpGet]
        [Route("api/get")]
        public int getInt()
        {
            return 1;
        }
    }
}
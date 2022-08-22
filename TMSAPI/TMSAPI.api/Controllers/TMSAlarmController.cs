using Microsoft.AspNetCore.Mvc;
using TMSAPI.api.Repositories;

namespace TMSAPI.api.Controllers
{
    [ApiController]

    [Route("TMSALARMS")]
    public class TMSAlarmController : Controller
    {
        private readonly IAlarms alarms;

        public TMSAlarmController(IAlarms alarms)
        {
            this.alarms = alarms;
        }

        [HttpGet]

        public IActionResult GetAllAlarms()
        {
            var alarmslist = alarms.GetFinalAlarms();
            return Ok(alarmslist);

        }
    }
}

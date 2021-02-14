using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace datetime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatetimeController : ControllerBase
    {
        private const string DEFAULT_FORMAT = "dd.mm.yyyy hh:MM:ss";

        private readonly ILogger<DatetimeController> _logger;

        public DatetimeController(ILogger<DatetimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return ";)";
        }

        [HttpGet("Now")]
        public JsonResult GetNow()
        {
            return new JsonResult(DateTime.Now);
        }

        [HttpGet("NowFormatted")]
        public JsonResult GetNowFormatted(string format = DEFAULT_FORMAT)
        {
            return new JsonResult(DateTime.Now.ToString(format));
        }

        [HttpGet("LongTimeString")]
        public JsonResult GetLongTimeString()
        {
            return new JsonResult(DateTime.Now.ToLongTimeString());
        }

        [HttpGet("ShortTimeString")]
        public JsonResult GetShortTimeString()
        {
            return new JsonResult(DateTime.Now.ToShortTimeString());
        }

        [HttpGet("ToLongDateString")]
        public JsonResult GetToLongDateString()
        {
            return new JsonResult(DateTime.Now.ToLongDateString());
        }

        [HttpGet("ShortDateString")]
        public JsonResult GetShortDateString()
        {
            return new JsonResult(DateTime.Now.ToShortDateString());
        }
    }
}

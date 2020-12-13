using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreHW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
//using ASPNETCoreHW1.Models;

namespace ASPNETCoreHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IOptions<AppSettings> appSettings;
        public ConfigController(IOptions<AppSettings> appSettings)
        {
            this.appSettings = appSettings;
        }

        [HttpGet("")]
        public ActionResult<AppSettings> GetAppSetting()
        {
            return appSettings.Value;
        }

    }
}
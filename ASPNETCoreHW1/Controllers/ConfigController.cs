using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreHW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
//using ASPNETCoreHW1.Models;

namespace ASPNETCoreHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IOptionsSnapshot<AppSettings> appSettings;
        private readonly ILogger<ConfigController> logger;
        public ConfigController(IOptionsSnapshot<AppSettings> appSettings, ILogger<ConfigController> logger)
        {
            this.appSettings = appSettings;
            this.logger = logger;
        }

        [HttpGet("")]
        public ActionResult<AppSettings> GetAppSetting()
        {
            logger.LogTrace("LogTrace");
            logger.LogDebug("LogDebug");
            logger.LogInformation("LogInformation");
            logger.LogWarning("LogWarning");
            logger.LogError("LogError");
            logger.LogCritical("LogCritical");

            logger.LogInformation("Getting item {ID} at {RequestTime}", "12345", DateTime.Now);

            return appSettings.Value;
        }

    }
}
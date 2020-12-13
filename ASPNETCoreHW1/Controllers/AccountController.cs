using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreHW1.Helpers;
using ASPNETCoreHW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using ASPNETCoreHW1.Models;

namespace ASPNETCoreHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> logger;
        private readonly JwtHelpers jwt;
        public AccountController(ILogger<AccountController> logger, JwtHelpers jwt)
        {
            this.logger = logger;
            this.jwt = jwt;
        }


        [HttpPost("~/login")]
        public ActionResult<LoginModel> Login(LoginModel model)
        {
            
            if (ValidateUser(model)){
                LoginResult r = new LoginResult(){
                    Token = jwt.GenerateToken(model.Username, 20)
                };
                return Ok(r);
            }

            return NoContent();
        }

        private bool ValidateUser(LoginModel model){

            return true;
        }

    }
}
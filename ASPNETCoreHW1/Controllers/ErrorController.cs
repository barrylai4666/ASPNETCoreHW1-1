using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ASPNETCoreHW1.Controllers
{
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        [Route("/Error")]
        [Produces("application/json")]
        public ActionResult ErrorPage([FromServices] IHostingEnvironment webHostEnvironment)
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var ex = feature?.Error;
            var isDev = webHostEnvironment.IsDevelopment();
            var problemDetails = new ProblemDetails
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Instance = feature?.Path,
                Title = isDev ? $"{ex.GetType().Name}: {ex.Message}" : "An error occurred.",
                Detail = isDev ? ex.StackTrace : null
            };

            return StatusCode(problemDetails.Status.Value, problemDetails);
        }


        //[HttpGet]
        //[Route("/Error")]
        //[Produces("application/json")]
        //public IActionResult Error() => Problem();

    }
}

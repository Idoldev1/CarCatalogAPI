using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers;

/*public class ErrorController : Controller
{
    private readonly ILogger<ErrorController> logger;

    public ErrorController(ILogger<ErrorController> logger)
    {
        this.logger = logger;
    }




    [Route("Error/{statusCode}")]
    public IActionResult HttpStatusCodeHandler(int statusCode)
    {
        var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>;

        switch (statusCode)
        {
            case 404:
                ViewBag.ErrorMessage =
                logger.LogWarning($"404 Error Occured Path = {statusCodeResult.OriginalPath}" + 
                $"and QuerryString = {statusCodeResult.}");

        }
        return NotFound();
    }


    [Route("Error")]
    [AllowAnonymous]
    public IActionResult Error()
    {
        var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        logger.LogError($"The path {exceptionDetails?.Path} threw an exception " + $"{exceptionDetails?.Error}");

        return NotFound();
    }
}*/
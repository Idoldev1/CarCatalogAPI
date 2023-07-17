using System.Net;
using Microsoft.AspNetCore.Diagnostics;


namespace FirstWebAPI.ErrorModel;
public static class ErrorHandler
{
    public static void ConfigureExceptionHandler(this WebApplication app,
    ILogger logger)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    logger.LogError($"Something went wrong: {contextFeature.Error}");
                    await context.Response.WriteAsync(new Error()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal Server Error.",
                    }.ToString());
                }
            });
        });
    }
}
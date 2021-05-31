using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Mail_API.Models.Logging
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private readonly ILog _nLog;

        public RequestLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, ILog nLog)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestLoggingMiddleware>();
            _nLog = nLog;
        }

        public async Task Invoke(HttpContext context)
        {

            try
            {
                await _next(context);
            }
            finally
            {
                _nLog.Information(
                        "Request {method} {url} {ipAddress} {body} => {statusCode}" +
                        context.Request?.Method +
                        context.Request?.Path.Value +
                        context.Response?.StatusCode +
                        context.Connection.RemoteIpAddress?.ToString()
                );

            }
        }
    }
}

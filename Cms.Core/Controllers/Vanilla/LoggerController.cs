using EPiServer.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Cms.Core.Controllers
{
    public class LoggerController : Controller
    {
        private readonly ILogger<LoggerController> _logger;

        public LoggerController(ILogger<LoggerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var logger = LogManager.GetLogger(typeof(LoggerController));
            logger.Error("Log Manager Error");

            _logger.LogTrace("Logging Trace Message");
            _logger.LogDebug("Logging Debug Message");
            _logger.LogInformation("Logging Information Message");
            _logger.LogWarning("Logging Warning Message");
            _logger.LogError("Logging Error Message {loginTime}", DateTime.Now);
            _logger.LogCritical("Logging Critical Message");

            return Ok();
        }
    }
}

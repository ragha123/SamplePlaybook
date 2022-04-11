using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook.Services
{
    public class SamplePlayService : ISamplePlayService
    {
        private readonly ILoggingService _loggingService;
        private readonly ILogger<SamplePlayService> _logger;

        public SamplePlayService(ILoggingService loggingService, ILogger<SamplePlayService> logger)
        {
           _loggingService = loggingService;
            _logger = logger;
        }

        public object ProcessMessage(string message)
        {
            _logger.LogInformation($"Message : {message}");
            _loggingService.LogMessage(message);
            return _loggingService;
        }
    }
}

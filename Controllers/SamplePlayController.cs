using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamplePlaybook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplePlayController : ControllerBase
    {
        private readonly ISamplePlayService _samplePlayService;
        public SamplePlayController(ISamplePlayService samplePlayService)
        {
            _samplePlayService = samplePlayService;
        }

        [HttpGet("/getmessage/{message}")]
        public IActionResult GetMessage(string message)
        {
            var response = _samplePlayService.ProcessMessage(message);
            return Ok(response);
        }

    }
}

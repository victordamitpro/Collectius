using Microsoft.AspNetCore.Mvc;
using Recruitment.API.Handlers;
using Recruitment.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recruitment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            var handler = new CalculateHashCommandHandler();
            var result = await handler.HandleAsync(new CalculateHashCommand { Login = "123", PassWord = "ac" });
            return result.Data;
        }

        [HttpHead]
        public async Task<string> Head()
        {
            var handler = new CalculateHashCommandHandler();
            var result = await handler.HandleAsync(new CalculateHashCommand { Login = "123", PassWord = "ac" });
            return result.Data;
        }
    }
}

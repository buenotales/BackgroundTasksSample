using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiBackgroudServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok($"{DateTime.UtcNow:o}");
        }
    }
}
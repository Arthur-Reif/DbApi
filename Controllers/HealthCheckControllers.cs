using Microsoft.AspNetCore.Mvc;

namespace DbApi.Controllers
{
    [ApiController]
    [Route("[health]")]
    public class HealthCheckController : ControllerBase //o ControllerBase tem muitas coisas q precisamos
    {
        
        [HttpGet("/health")]
        public IActionResult HealthCheck()
        {
            // return StatusCode(200, "Healthy");
            return Ok("Healthy");
        }
    }
}
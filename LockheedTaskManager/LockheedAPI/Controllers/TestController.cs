using Microsoft.AspNetCore.Mvc;

namespace LockheedAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Backend working!" });
        }
    }
}
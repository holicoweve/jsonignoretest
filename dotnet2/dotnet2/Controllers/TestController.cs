using Microsoft.AspNetCore.Mvc;

namespace dotnet2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Demo
            {
                Secret = "You should not see this",
                Plain = "You should see this"
            });
        }
    }
}
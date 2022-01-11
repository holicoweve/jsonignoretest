using Microsoft.AspNetCore.Mvc;

namespace dotnet6.Controllers;

[ApiController]
[Route("[controller]")]
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
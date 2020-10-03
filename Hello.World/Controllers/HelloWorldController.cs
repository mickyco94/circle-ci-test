using Microsoft.AspNetCore.Mvc;

namespace Hello.World.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("hello");
    }
}

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TestController : BaseController
{
    [HttpGet("testRequest")]
    public ActionResult<string> GetHelloWorldText()
    {
        return BadRequest("Hello World");
    }
}
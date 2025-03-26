using Microsoft.AspNetCore.Mvc;

namespace ApiExplorerHub.Controller;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("test")]
    public string GetHelloWorldText()
    {
        return "Hello World!";
    }


    
}
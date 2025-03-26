using Microsoft.AspNetCore.Mvc;

namespace ApiExplorerHub.Controller;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet("hello/{name}")]
    public string GetGreetingByName(string name)
    {
        return $"Hello World, {name}!";
    }
}
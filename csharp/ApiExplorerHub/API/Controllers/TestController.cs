using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TestController : BaseController
{
    [HttpGet("test")]
    public string GetHelloWorldText()
    {
        return "Hello World!";
    }
}
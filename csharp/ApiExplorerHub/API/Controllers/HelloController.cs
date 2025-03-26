using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HelloController : BaseController
{
    [HttpGet("hello/{name}")]
    public string GETgreetingByName(string name)
    {
        return $"Hello {name}";
    }
    
}   
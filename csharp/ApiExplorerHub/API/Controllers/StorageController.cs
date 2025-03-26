using API.Storage;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class StorageController : BaseController
{
    private readonly DataContext _context;
    public StorageController(DataContext dataContext)
    {
        this._context = dataContext;
    }
    
    [HttpGet("SetString/{value}")]
    public void SetString(string value)
    {
        _context.Str = value;
    }
    
    [HttpGet("SetString")]
    public string GetString()
    {
        return _context.Str;
    }
}
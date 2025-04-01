using API.Dto;
using API.Model;
using API.Storage;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ContactManagmentController : BaseController
{
    private readonly IStorage _storage;
    
    public ContactManagmentController(IStorage inMemoryStorage)
    {
        this._storage = inMemoryStorage;     
    }
    
    [HttpGet("contacts")]
    public ActionResult<List<Contact>> Get()
    {
        return Ok(_storage.Get());
    }
    
    [HttpPost("contacts")]
    public IActionResult Create([FromBody]Contact contact)
    {
        Contact res = _storage.Add(contact);
        if (res != null) return Ok(contact);
        return BadRequest();
    }

    [HttpDelete("contacts/{id}")]
    public IActionResult Delete(int id)
    {
        bool res = _storage.Remove(id);
        if (res) return Ok();
        return BadRequest("Contact not found");
    }

    [HttpPut("contacts/{id}")]
    public IActionResult Update(int id, [FromBody] ContactDto contactDto)
    {
        bool res = _storage.Update(id, contactDto);
        if (res) return Ok();
        return BadRequest();
    }
    
    
    
}
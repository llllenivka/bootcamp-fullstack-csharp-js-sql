using API.Dto;
using API.Model;
using API.Storage;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ContactManagmentController : BaseController
{
    private readonly ContactStorage _storage;
    
    public ContactManagmentController(ContactStorage contactStorage)
    {
        this._storage = contactStorage;     
    }
    
    [HttpPost("contacts")]
    public IActionResult Create([FromBody]Contact contact)
    {
        bool res = _storage.Add(contact);
        if (res) return Created();
        return BadRequest();
    }

    [HttpGet("contacts")]
    public ActionResult<List<Contact>> Get()
    {
        return Ok(_storage.Get());
    }

    [HttpGet("contacts/{id}")]
    public ActionResult<Contact> Get(int id)
    {
        if (id < 0)
        {
            return BadRequest(" Неверный формат ID ");
        }
        
        var res = _storage.Get(id);
        if (res == null) NotFound($"Контакт {id} не найден");
        return Ok(res);

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
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
    public void Create([FromBody]Contact contact)
    {
        _storage.Contacts.Add(contact);
    }

    [HttpGet("contacts")]
    public List<Contact> Get()
    {
        return _storage.Contacts;
    }

    [HttpDelete("contacts/{id}")]
    public List<Contact> Delete(int id)
    {
        _storage.Contacts.RemoveAll(x => x.Id == id);
        return _storage.Contacts;
    }
    
    
    
}
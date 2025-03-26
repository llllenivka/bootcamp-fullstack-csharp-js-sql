using API.Model;

namespace API.Storage;

public class ContactStorage
{
    public List<Contact> Contacts { get; set; }

    public ContactStorage()
    {
        this.Contacts = new List<Contact>();
    }
}
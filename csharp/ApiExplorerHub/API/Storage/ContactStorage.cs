using API.Dto;
using API.Model;

namespace API.Storage;

public class ContactStorage
{
    private List<Contact> Contacts { get; set; }

    public ContactStorage()
    {
        this.Contacts = new List<Contact>();

        for (int i = 1; i <= 5; i++)
        {
            this.Contacts.Add(new Contact()
            {
                Id = i,
                Name = $"Name {i}",
                Email = $"{Guid.NewGuid()}@email.com",
            });
            
        }
    }

    public List<Contact> Get()
    {
        return this.Contacts;
    }

    public Contact Get(int id)
    {
        foreach (Contact contact in this.Contacts)
        {
            if (contact.Id == id)
            {
                return contact;
            }
        }
        return null;
    }
    

    public bool Add(Contact contact)
    {
        foreach (var item in Contacts)
        {
            if(contact.Id == item.Id)
                return false;
        }

        Contacts.Add(contact);
        return true;
    }
    
    public bool Remove(int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
                this.Contacts.Remove(contact);
                return true;
            }
        }

        return false;
    }
    

    public bool Update(int id, ContactDto contactDto)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
                
                if (!string.IsNullOrEmpty(contactDto.Name))
                {
                    contact.Name = contactDto.Name;
                }

                if (!string.IsNullOrEmpty(contactDto.Email))
                {
                    contact.Email = contactDto.Email;
                }
                
                return true;
            }
            
        }
        return false;
    }

    
}
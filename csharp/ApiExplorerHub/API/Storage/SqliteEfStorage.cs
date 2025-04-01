using API.DataContext;
using API.Dto;
using API.Model;

namespace API.Storage;

public class SqliteEfStorage : IStorage
{
    protected readonly SqliteDbContext _context;

    public SqliteEfStorage(SqliteDbContext context)
    {
        _context = context;
    }

    public List<Contact> Get()
    {
        return _context.Contacts.ToList();
    }

    public Contact Add(Contact contact)
    {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
        return contact;
    }

    public bool Remove(int id)
    {
        var contact = _context.Contacts.Find(id);
        _context.Contacts.Remove(contact);
        _context.SaveChanges();
        return contact != null;
    }

    public bool Update(int id, ContactDto contactDto)
    {
        var contact = _context.Contacts.Find(id);
        if (contact == null) return false;
        contact.Name = contactDto.Name;
        contact.Email = contactDto.Email;
        _context.Contacts.Update(contact);
        _context.SaveChanges();
        return contact != null;
    }
}
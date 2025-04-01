using API.DataContext;
using API.Model;

namespace API.Storage;

public class SqlitePaginationEfStorage : SqliteEfStorage, IPaginationStorage
{
    public SqlitePaginationEfStorage(SqliteDbContext context) : base(context)
    {
        
    }

    public Contact GetById(int id)
    {
        return base._context.Contacts.Find(id);
    }

    public (List<Contact>, int TotalCount) GetContacts(int pageNumber, int pageSize)
    {
        int total = base._context.Contacts.Count();
        List<Contact> contacts = base._context.Contacts
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        
        return (contacts, total);
    }
}
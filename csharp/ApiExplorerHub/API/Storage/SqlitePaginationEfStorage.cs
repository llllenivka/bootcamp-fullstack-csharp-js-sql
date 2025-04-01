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
}
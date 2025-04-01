using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext;

public class SqliteDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
    {
    }
    
}
using API.Dto;
using API.Model;
using Microsoft.Data.Sqlite;

namespace API.Storage;

public class SqliteStorage : IStorage
{
    private readonly string connectionString;

    public SqliteStorage(string connectionString)
    {
        this.connectionString = connectionString;
    }
    private IStorage _storageImplementation;
    public List<Contact> Get()
    {
        var contacts = new List<Contact>();

       
        using var connection = new SqliteConnection(connectionString);
        connection.Open();
        
        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM contacts";
        using var reader =  command.ExecuteReader();
        while (reader.Read())
        {
            contacts.Add(new Contact()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2)
            });
        }
        
        return contacts;
    }

    public Contact Add(Contact contact)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();
        
        var command = connection.CreateCommand();
        
        string sql = @"INSERT INTO contacts (name, email) VALUES (@name, @email);
                    SELECT last_insert_rowid();
                    ";
        command.CommandText = sql;
        command.Parameters.AddWithValue("@name", contact.Name);
        command.Parameters.AddWithValue("@email", contact.Email);
        
        contact.Id = Convert.ToInt32(command.ExecuteScalar());
        return contact;
    }

    public bool Remove(int id)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();
        
        var command = connection.CreateCommand();
        string sql = "DELETE FROM contacts WHERE id = @id";
        command.CommandText = sql;
        command.Parameters.AddWithValue("@id", id);
        
        return command.ExecuteNonQuery() > 0;
    }

    public bool Update(int id, ContactDto contactDto)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();
        
        string sql = "UPDATE contacts SET name=@name, email=@email WHERE id = @id";
        
        var command = connection.CreateCommand();
        command.CommandText = sql;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name", contactDto.Name);
        command.Parameters.AddWithValue("@email", contactDto.Email);
        
        return command.ExecuteNonQuery() > 0;
    }
}
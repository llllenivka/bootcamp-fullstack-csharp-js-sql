using API.DataContext;
using API.Model;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace API.Seed;

public class SqliteEfFakerInitializer : IInitializer
{
    private readonly SqliteDbContext _context;

    public SqliteEfFakerInitializer(SqliteDbContext context)
    {
        _context = context;
    }

    private string GenerateEmailForName(string name)
    {
        string email = Transliterater(name)
            .ToLower()
            .Replace(" ", ".") + "@example.ru";
        
        return email;
    }

    private string Transliterater(string name)
    {
        Dictionary<char, string> translitTable = new Dictionary<char, string>
        {
            {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, {'е', "e"}, 
            {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"}, {'й', "y"}, {'к', "k"},
            {'л', "l"}, {'м', "m"}, {'н', "n"}, {'о', "o"}, {'п', "p"}, {'р', "r"},
            {'с', "s"}, {'т', "t"}, {'у', "u"}, {'ф', "f"}, {'х', "kh"}, {'ц', "ts"},
            {'ч', "ch"}, {'ш', "sh"}, {'щ', "shch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""},
            {'э', "e"}, {'ю', "yu"}, {'я', "ya"}

        };

        var result = "";
        foreach (var ch in name.ToLower())
        {
            if (translitTable.ContainsKey(ch))
                result += translitTable[ch];
            else
                result += ch;
        }
        
        return result;
    }
    
    
    

    public void Initialize()
    {
        _context.Database.Migrate();
        if (!_context.Contacts.Any())
        {
            var faker = new Faker<Contact>("ru")
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, (f, c) => GenerateEmailForName(c.Name));
            
            var contacts = faker.Generate(250);
            
            _context.Contacts.AddRange(contacts);
            _context.SaveChanges();
        }
        
        
    }
}
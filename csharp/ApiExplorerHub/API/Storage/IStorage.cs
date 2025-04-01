using API.Dto;
using API.Model;

namespace API.Storage;

public interface IStorage
{
    List<Contact> Get();
    Contact Add(Contact contact);
    bool Remove(int id);
    bool Update(int id, ContactDto contactDto);
}
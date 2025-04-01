using API.Model;

namespace API.Storage;

public interface IPaginationStorage : IStorage
{
    Contact GetById(int id);
    (List<Contact>, int TotalCount) GetContacts(int pageNumber, int pageSize);
}
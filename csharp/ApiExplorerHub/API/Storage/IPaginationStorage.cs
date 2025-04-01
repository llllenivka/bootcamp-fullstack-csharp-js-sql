using API.Model;

namespace API.Storage;

public interface IPaginationStorage : IStorage
{
    Contact GetById(int id);
}
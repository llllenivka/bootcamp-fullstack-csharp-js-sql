public class Repository : IRepository
{


    private Person[] storage;
    private int count;
    private int index = 0;
    public int Index => index;

    public Repository(int count)
    {
        this.count = count;
        storage = new Person[count];
    }


    public void Append(params Person[] people)
    {
        foreach(var person in people)
        {
            try 
            {
                storage[index++] = person; 
            }
            catch(IndexOutOfRangeException)
            {
                index--;
                Console.WriteLine($"Добавление '{person.Name}' отменено. База данных достигла максимального размера ({count} записей).");
            }
        }
    }

    public Person GetById(int id) 
    {
        if(id < 0 || id >= index) return new NullPerson();
        else return storage[id];
    }

}
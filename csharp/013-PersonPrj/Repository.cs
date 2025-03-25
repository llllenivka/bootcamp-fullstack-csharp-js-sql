public class Repository
{
    private Person[] people;
    private int count;
    private int index = 0;
    public int Index => index;

    public Repository(int count)
    {
        this.count = count;
        people = new Person[count];
    }

    public void Append(Person person) 
    { 
        try 
        {
            people[index++] = person; 
        }
        catch(IndexOutOfRangeException)
        {
            index--;
            Console.WriteLine($"Добавление '{person.Name}' отменено. База данных достигла максимального размера ({count} записей).");
        }
    }

    public Person GetPersonById(int id) 
    {
        if(id < 0 || id >= index) return new Person("empty", -1);
        else return people[id];
    }


}
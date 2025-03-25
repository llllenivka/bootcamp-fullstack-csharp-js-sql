class Repository
{
    private Person[] people;
    private int count;
    private int index = 0;

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

    public void Print()
    {
        int idx = 1;
        foreach(var person in people)
        {
            if(person == null) break;
            Console.WriteLine($"{idx++}. Имя: {person.Name} Возраст: {person.Age}.");
        }
    }
}
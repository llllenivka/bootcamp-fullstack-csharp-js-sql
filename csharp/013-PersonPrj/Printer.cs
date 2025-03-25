public class Printer
{
    public void Print(Repository repository)
    {
        int max = repository.Index;
        for(int i = 0; i < max; i++)
        {
            Person person = repository.GetPersonById(i);
            Console.WriteLine($"{i + 1}. Имя: {person.Name} Возраст: {person.Age}.");
        }
    }
}
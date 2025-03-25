public class Printer
{
    public void Print(IRepository repository)
    {
        int max = repository.Index;
        for(int i = 0; i < max; i++)
        {
            Person person = repository.GetById(i);
            Console.WriteLine(person.ToString());
        }
    }
}
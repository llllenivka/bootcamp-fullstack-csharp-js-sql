Person person1 = new("Ваня К.", 23);
Person person2 = new("Юля К.", 20);

Repository repository = new(10);
for(int i = 0; i < 100; i++)
{
    repository.Append(person1);
}

Printer printer = new();

printer.Print(repository);

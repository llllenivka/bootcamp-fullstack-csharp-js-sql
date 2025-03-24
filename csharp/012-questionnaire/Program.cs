ushort points = 0;

Console.WriteLine("Что означает слово 'cat'? [кошка, собака]");
var answer = Console.ReadLine();
if(answer == "кошка")
{
    Console.WriteLine("Всё верно! 😎");
    points += 10;
} 
else Console.WriteLine("Нужно подумать ещё 🫣");

Console.WriteLine("Что означает слово 'dog'? [кошка, собака]");
answer = Console.ReadLine();
if(answer == "собака") 
{
    Console.WriteLine("Всё верно! 😎");
    points += 10;
}
else Console.WriteLine("Нужно подумать ещё 🫣");

Console.WriteLine("Счет: " + points);
Console.Write("Введите сумму счета: ");
double billAmount = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите процент чаевых: ");
double tipPercentage = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите кол-во человек: ");
int numberOfPeople = int.Parse(Console.ReadLine());
Console.WriteLine();

if(billAmount <= 0 || tipPercentage < 0 || numberOfPeople <= 0 )
{
    Console.WriteLine("Ошибка входных данных.");
} 
else
{
    double tipAmount = 1000 * tipPercentage / 100;
    double totalAmount = billAmount + tipAmount;
    double perPersonAmount = totalAmount / numberOfPeople;

    Console.WriteLine("Общий счёт: " + totalAmount);
    Console.WriteLine("Процент чаевых: " + tipAmount + "%");
    Console.WriteLine($"С каждого: {perPersonAmount}");
}
Console.Write("Введите сумму счета: ");
var result1 = double.TryParse(Console.ReadLine(), out double billAmount);
Console.WriteLine();

Console.Write("Введите процент чаевых: ");
var result2 = double.TryParse(Console.ReadLine(), out double tipPercentage);
Console.WriteLine();

Console.Write("Введите кол-во человек: ");
var result3 = int.TryParse(Console.ReadLine(), out int numberOfPeople);
Console.WriteLine();

if( !result1 || !result2 || !result3 ||
    billAmount <= 0 || tipPercentage < 0 || numberOfPeople <= 0 )
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
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if(number1>number2)
{
    Console.WriteLine($"max={number1}");
}  
else
{
    Console.WriteLine($"max={number2}");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 == 0 || a / 100 > 9)
Console.WriteLine("Число не является трехзначным");
else
Console.WriteLine(a%10);
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
string input1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string input2 = Console.ReadLine();
int a = Convert.ToInt32(input1);
int b = Convert.ToInt32(input2);

if (a*a == b)
    Console.WriteLine("Одно число является квадратом другого");
else if (b*b == a)
    Console.WriteLine("Одно число является квадратом другого");
else 
    Console.WriteLine("Ни одно число не является квадратом другого");


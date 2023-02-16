// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;


if (a>b)
    Console.WriteLine("Ваше максимальное число = " + a);
else if (b<a)
    Console.WriteLine("Ваше максимальное число = " + b);
else 
    Console.WriteLine("Они равны");



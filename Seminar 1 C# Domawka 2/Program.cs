// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b)
max = a;
else 
max = b;
if (c > max)
max = c;

//int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
Console.WriteLine("Максимальное число = " + max);

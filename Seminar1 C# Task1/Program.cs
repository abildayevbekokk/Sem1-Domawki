// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
Console.WriteLine("Квадрат числа: {0}", Math.Pow(b, 2));

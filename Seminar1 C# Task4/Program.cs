// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = -a; i<=a; i++)
    Console.Write(i + " ");

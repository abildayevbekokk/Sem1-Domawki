﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
    if (i % 2 == 0)
        Console.Write(i + " ");

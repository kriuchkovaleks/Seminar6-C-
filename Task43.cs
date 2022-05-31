﻿/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/



void crossPoint(double b1, double b2, double k1, double k2)
{
    double y = 0;
    double x = 0;

    if ((k2 - k1) == 0 || (k1 - k2) == 0)
    {
        Console.WriteLine("Решения не существует, прямыe параллельны");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"({x} ; {y})");
    }

}
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

crossPoint(b1, b2, k1, k2);


﻿// Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(n, b));



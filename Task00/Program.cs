﻿// Задача 0
// Напишите программу, которая на вход
// 1. принимает число и 
// 2. выдаёт его квадрат (число
// умноженное на само себя).
// вывод результата
// Например:
// 4 -> 16
// -3 -> 9
Console.Clear();
Console.Write("Ведите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square} ");



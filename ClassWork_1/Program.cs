﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int A = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите сторону B");
int B = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите сторону C");
int C = Convert.ToInt32((Console.ReadLine()));


if(A < B + C && B < A + C && C < A + B)  Console.WriteLine("Yes");
else Console.WriteLine("No");

﻿/* Напишите программу, которая принимает на вход число N 
и выдает таблицу кубов чисел от 1 до N */

Console.WriteLine("Введите число: ");        
int N = int.Parse(Console.ReadLine());

for ( int a = 1; a <= N; a++)
{
    Console.Write(Math.Pow(a, 3) + ", ");
}


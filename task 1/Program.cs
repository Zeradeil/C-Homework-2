﻿/*Задача 1: Напишите программу, которая принимает на
 вход трёхзначное число и на выходе показывает вторую 
 цифру этого числа. Не использовать строки для 
 расчета.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    Console.WriteLine(num / 10 % 10);
}
else
{
    Console.WriteLine("число не треххначное");
}



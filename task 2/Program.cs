﻿/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 != 0)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    System.Console.WriteLine(num);
}
else
    System.Console.WriteLine("третьей цифры нет");
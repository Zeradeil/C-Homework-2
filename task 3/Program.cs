/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день
 недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

public void InputInt(int num)
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine($"нет");
    }
    else
    {
        Console.WriteLine($"да");
    }
}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7)
{
    num = num % 7;
    Console.WriteLine(InputInt);
}
else
{
    Console.WriteLine(InputInt);
}

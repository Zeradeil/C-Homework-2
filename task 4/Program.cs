/* Задача 2: Напишите программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру
 этого числа. Не использовать строки для расчета.
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1000 && num > 99)
{
    int num1 = num / 100 * 10 + num % 10;
    Console.WriteLine(num1);
}
else Console.WriteLine("Число не трёхзначное");

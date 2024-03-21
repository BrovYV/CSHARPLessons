﻿// напишите программу, которая выводит третьюю слева цифру
// заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => третьей цифры нет


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * -1;
}

if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    Console.Write($" Третья цифра равна = {num % 10}");
}
else
{
    Console.Write("Третьей цифры нет");
}
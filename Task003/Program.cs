﻿/*Задача 67: Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int number = Input("Введите число: ");

Console.WriteLine(OutputFunction(number));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int num)
{
    if (num / 10 == 0)
    {
        return num;
    }
    return num % 10 + OutputFunction(num/10);
}
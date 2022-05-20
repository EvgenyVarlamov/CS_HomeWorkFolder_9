/* Задача 69: Напишите программу, которая на вход
 принимает два числа A и B, и возводит число А в 
 целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int numberFirst = Input("Введите значение A: ");
int numberSecond = Input("Введите значение B: ");

Console.WriteLine(OutputFunction(numberFirst, numberSecond));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numFirst, int numSecond)
{
    if (numSecond == 0)
    {
        return 1;
    }
    return numFirst * OutputFunction(numFirst, numSecond - 1);
}
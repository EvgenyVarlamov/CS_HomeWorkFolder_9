/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдет сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int numberStart = Input("Введите значение M: ");
int numberEnd = Input("Введите значение N: ");

Console.WriteLine(OutputFunction(numberStart, numberEnd));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numStart, int numEnd)
{
    if (numEnd == numStart)
    {
        return numStart;
    }
    return  numEnd + OutputFunction(numStart, numEnd - 1);
}
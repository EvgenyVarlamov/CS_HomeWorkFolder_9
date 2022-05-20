/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2,"
*/

int number = Input("Введите значение N: ");

Console.WriteLine(OutputFunction(number));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int num)
{
    if (num == 1)
    {
        return 1;
    }
    Console.Write(num + ", ");
    return OutputFunction(num-1);
}
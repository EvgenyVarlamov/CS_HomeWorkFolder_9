/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 !!! при m = 2, n = 3 -> 9, а при m = 3, n = 2 -> 29
*/ 

int numberFirst = Input("Введите значение m: ");
int numberSecond = Input("Введите значение n: ");

Console.WriteLine(AckermanFunction(numberFirst, numberSecond));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int numFirst, int numSecond)
{
    if (numFirst == 0)
    {
        return numSecond + 1;
    }
    else if (numFirst > 0 && numSecond == 0)
    {
        return AckermanFunction(numFirst - 1, 1);
    }
    return AckermanFunction(numFirst - 1, AckermanFunction(numFirst, numSecond - 1));
}
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int GetNumber(string msg)
{
    Console.Write(msg);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Некорректное значение");
    }
    return result;
}

int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    else
    {
        return (GetAkkerman(m - 1, GetAkkerman(m, n - 1)));
    }
}

int m = GetNumber("Введите не отрицательное число M: ");
int n = GetNumber("Введите не отрицательное число N: ");
Console.WriteLine(GetAkkerman(m, n));
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
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

int GetSum(int m, int n, int sum)
{
    if (n == m) return sum;
    else
    {
        sum = sum + n;
        return GetSum(m, n - 1, sum);
    }
}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int sum = m;
Console.WriteLine("Сумма натуральных элеметов");
Console.WriteLine(GetSum(m, n, sum));
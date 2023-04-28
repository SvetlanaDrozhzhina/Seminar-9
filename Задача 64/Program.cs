// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод");
        }
    }
    return result;
}

string WriteNubers(int number)
{
    if (number == 1) return ("1");
     else 
     {
        return number.ToString() + " " + WriteNubers(number - 1);
     }
}

int num = GetNumber("Введите натуральное число:");
Console.WriteLine(WriteNubers(num));
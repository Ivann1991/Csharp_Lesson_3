// Напишите программу которая на вход принимает число N и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();
int usernum;

try
{
    Console.Write("Введи целое число ");
    usernum = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"ошибка ввода данных {exc.Message} ");
    return;
}
Console.Write($"{usernum} -> ");
Pow(usernum);


////////////////////////////////////////////////////////////////
static void Pow(int usernum)
{
    usernum = Math.Abs(usernum);
    for (int a = 1; a < usernum; a++)
    {
        Console.Write($"{a * a}, ");
    }
    Console.Write(usernum * usernum);
}



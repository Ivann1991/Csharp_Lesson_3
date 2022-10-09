// Напишите программу которая на вход принимает число N и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

int usernum;

while (true)
{
    Console.Write("Введи целое число ");
    if (int.TryParse(Console.ReadLine(), out usernum))
        break;
    Console.WriteLine ("Ошибка ввода, повторите еще раз");
}

Console.Write($"{usernum} -> ");
Pow3(usernum);



////////////////////////////////////////////////////////////
static void Pow3(int usernum)
{
    usernum = Math.Abs(usernum);
    for (int a = 1; a < usernum; a++)
        Console.Write ($"{a*a*a}, ");
    Console.Write (usernum*usernum*usernum);    
}
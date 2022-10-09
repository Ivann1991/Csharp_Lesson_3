// Напиишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
int usernum;
try
{
    Console.Write("Введи целое пятизначное число ");
    usernum = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exc)
{
    Console.Write($"ошибка ввода {exc.Message} ");
    return;
}
if (usernum < 0)
    Console.Write($"твоё число {usernum} отрицательное и не может быть палиндромом ");
else if (usernum >= 0 && usernum < 10000)
    Console.Write($"твоё число {usernum} не пятизначное ");
else if (usernum > 99999)
    Console.Write($"твоё число {usernum} не пятизначное ");
else
    palindrome(usernum);


///////////////////////////////////////////////////////////////////////////////////

static void palindrome(int usernum)
{
    int a1 = usernum / 10000;
    int a2 = usernum / 1000 % 10;
    int b1 = usernum % 10;
    int b2 = usernum % 100 / 10;
    if (a1 == b1 && a2 == b2)
        Console.Write($"твоё число {usernum} является палиндромом");
    else
        Console.Write($"твоё число {usernum} не является палиндромом");
}
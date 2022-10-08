static void quarter(int Quarter)
{
    if (Quarter == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if (Quarter == 2)
        Console.WriteLine("x < 0 and y > 0");
    else if (Quarter == 3)
        Console.WriteLine("x < 0 and y < 0");
    else if (Quarter == 4)
        Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Не верно выбран номер четверти");
}

Console.Clear();

int Quarter;

try
{
    Console.WriteLine("Введи номер четверти, 1,2,3 или 4 ");
    Quarter = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных {exc.Message}");
    return;
}
quarter(Quarter); 



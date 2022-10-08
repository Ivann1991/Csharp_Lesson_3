// Напишите программу которая на вход принимает координаты двух точек и находит расстояние между ними в 2в пространстве
Console.Clear();
int x1, x2, y1, y2;

static int koords(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse (int x1, int x2, int y1, int y2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}



x1 = koords("Введи координату X первой точки ");
y1 = koords("Введи координату Y первой точки ");
x2 = koords("Введи координату X второй точки ");
y2 = koords("Введи координату Y второй точки ");

double distanse = Distanse(x1, x2, y1, y2);
Console.WriteLine(distanse);




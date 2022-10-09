// Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Clear();
int x1, x2, y1, y2, z1, z2;

static int koords(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}



x1 = koords("Введи координату X первой точки ");
y1 = koords("Введи координату Y первой точки ");
z1 = koords("Введи координату z первой точки ");
x2 = koords("Введи координату X второй точки ");
y2 = koords("Введи координату Y второй точки ");
z2 = koords("Введи координату z второй точки ");

double distanse = Distanse(x1, x2, y1, y2, z1, z2);
Console.WriteLine(distanse);

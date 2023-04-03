// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Read(string coordinate)
{
    System.Console.WriteLine($"Введите координату {coordinate}");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");

double SegmentLength = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
System.Console.WriteLine("Длина отрезка составляет");
System.Console.WriteLine(SegmentLength);
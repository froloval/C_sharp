// Напишите программу, кторая находит по координатам расстояние
// между точками в трехмерном пространстве.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double DistanceDot(double x1, double x2)
{
    double result = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
    return result;
}
double ProjectionDot(int x1, int x2)
{
    int result = x1 - x2;
    return result;
}
//-----------------------------------------------------------------

int x1 = Prompt("Введите x1");
int y1 = Prompt("Введите y1");
int z1 = Prompt("Введите z1");
int x2 = Prompt("Введите x2");
int y2 = Prompt("Введите y2");
int z2 = Prompt("Введите z2");
double DistanceXY = DistanceDot(ProjectionDot(x1, x2), ProjectionDot(y1, y2));
double distance = DistanceDot(DistanceXY, ProjectionDot(z1, z2));
Console.WriteLine($"Расстояние между точками равно {distance}");


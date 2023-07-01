// Напишите программу, которая по 
// координатам двух точек находит
// расстояние между ними

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double GetDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return distance;
}

//----------------------------------
int x1 = Prompt("Введите x1");
int y1 = Prompt("Введите y1");
int x2 = Prompt("Введите x2");
int y2 = Prompt("Введите y2");
Console.WriteLine($"{x1}  {y1}  {x2}  {y2}");
Console.WriteLine($"Расстояние между точками равно - {GetDistance(x1, y1, x2, y2)}");


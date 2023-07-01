// Напишите программу, которая по 
// заданным координатам точки
// находит номер четверти плоскости,
// где та располагается

int GetAreaNumber(int x, int y)
{
    int numberArea = 0;
    if ((x > 0) && (y > 0))
    {
        numberArea = 1;
    }
    if ((x < 0) && (y > 0))
    {
        numberArea = 2;
    }
    if ((x < 0) && (y < 0))
    {
        numberArea = 3;
    }
    if ((x > 0) && (y < 0))
    {
        numberArea = 4;
    }
    return numberArea;
}

//----------------------------------------
Console.WriteLine("Введите координаты");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Введите другие координаты");
}
else
{
    int result = GetAreaNumber(x, y);
    Console.WriteLine($"номер четверти {result}");
}

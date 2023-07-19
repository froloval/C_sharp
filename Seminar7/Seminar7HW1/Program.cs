// Задайте двумерный массив размером MxN, заполненый случайными
// вещественными числами.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] GetRandomDoubleArray(int countRow, int countColum)
{
    double[,] array = new double[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 11), 2);
        }
    }
    return array;
}
void PrintIntArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//---------------------------------------------
int countRow = Prompt("Введиту число");
int countColum = Prompt("Введиту число");
double[,] array = GetRandomDoubleArray(countRow, countColum);
PrintIntArray(array);


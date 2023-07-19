// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] GetRandomIntArray(int countRow, int countColum)
{
    int[,] array = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = new Random().Next(2, 9);
        }
    }
    return array;
}
int[,] FirstLastRowRevers(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tempEl = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tempEl;
    }
    return array;
}
//------------------------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);
Console.WriteLine();
PrintIntArray(FirstLastRowRevers(array));

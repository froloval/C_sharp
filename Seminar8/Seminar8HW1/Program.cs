// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного 
// массива.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
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
    Console.WriteLine();
}
int[,] FindPlaceElInString(int[,] array, int i)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int j = k + 1; j < array.GetLength(1); j++)
        {
            if (array[i, k] < array[i, j])
            {
                int temp = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
    return array;
}
int[,] SortArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        resultArray = FindPlaceElInString(array, i);
    }
    return resultArray;
}
//------------------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);
int[,] resultArray = SortArray(array);
PrintIntArray(resultArray);

Console.WriteLine("Hello, World!");

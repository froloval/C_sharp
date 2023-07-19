// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.


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
            array[i, j] = new Random().Next(0, 100);
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
int[,] GetCrossArray(int[,] array)
{
    int minEl = array[0, 0];
    int countColumMinEl = 0;
    int countRowMinEl = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minEl > array[i, j])
            {
                minEl = array[i, j];
                countColumMinEl = j;
                countRowMinEl = i;
            }
        }
    }
    Console.WriteLine(minEl);
    Console.WriteLine(countColumMinEl);
    Console.WriteLine(countRowMinEl);
    int[,] ResultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k1 = 0;
    for (int i = 0; i < ResultArray.GetLength(0); i++, k1++)
    {
        int k2 = 0;
        if (i == countRowMinEl)
        {
            k1++;
        }
        for (int j = 0; j < ResultArray.GetLength(1); j++, k2++)
        {
            if (j == countColumMinEl)
            {
                k2++;
            }
            ResultArray[i, j] = array[k1, k2];
        }
    }
    return ResultArray;
}
//------------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);
int[,] ResultArray = GetCrossArray(array);
PrintIntArray(ResultArray);

Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information

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
int[,] GetTransposeArray(int[,] array)
{
    int[,] ResultArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < ResultArray.GetLength(0); i++)
    {
        for (int j = 0; j < ResultArray.GetLength(1); j++)
        {
            ResultArray[i, j] = array[j, i];
        }
    }
    return ResultArray;
}
//------------------------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);
int[,] ResultArray = GetTransposeArray(array);
PrintIntArray(ResultArray);
Console.WriteLine();
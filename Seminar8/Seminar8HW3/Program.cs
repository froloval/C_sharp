// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

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
            array[i, j] = new Random().Next(2, 5);
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
int[,] GetMultiplMatrix(int[,] array1, int[,] array2)
{
    int[,] ResultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            ResultMatrix[i, j] = MultiplicationElMatrix(array1, array2, i, j);
        }
    }
    return ResultMatrix;
}
int MultiplicationElMatrix(int[,] array1, int[,] array2, int ii, int jj)
{
    int mult = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        mult = mult + (array1[ii, i] * array2[i, jj]);
        //Console.Write($" {mult} ");
    }
    //Console.WriteLine();
    return mult;
}
//---------------------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array1 = GetRandomIntArray(countRow, countColum);
PrintIntArray(array1);
countRow = Prompt("Введите количество строк ");
countColum = Prompt("Введите количество столбцов ");
int[,] array2 = GetRandomIntArray(countRow, countColum);
PrintIntArray(array2);
if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Данные матрицы не могут быть перемножены");
}
else
{
    int[,] ResultArray = GetMultiplMatrix(array1, array2);
    PrintIntArray(ResultArray);
}



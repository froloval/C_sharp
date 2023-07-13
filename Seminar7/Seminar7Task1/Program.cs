// See https://aka.ms/new-console-template for more information

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintIntArray(int[,] array, int countColum, int countRow)
{
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            Console.Write($" {array[i, j]}");
        }

    }
}
int[] GetRandomIntArray(int countRow, int countColum)
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
//---------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество строк ");
int[,] array = GetRandomIntArray[countRow, countColum];


Console.WriteLine("Hello, World!");

// Напишите программу, которая по заданному номеру элемента 
// двумерного массива возвращает его значение или сообщение об 
// отсутствии

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
//---------------------
int countRow = Prompt("Введите число строк");
int countColum = Prompt("Введите число столбцов");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);
int number = Prompt("Введите номер элемента");
if (number > countColum * countRow)
{
    Console.WriteLine("Элемента с таким индексом нет в массиве");
}
else
{
    //Console.WriteLine((number - 1) / countRow);
    //Console.WriteLine((number - 1) % countColum);
    Console.WriteLine($"Заначение элемента {array[(number - 1) / countRow, (number - 1) % countColum]}");
}


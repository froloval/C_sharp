// Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int CheckRepet(int[,,] array, int num)
{
    int i = 0;
    int j = 0;
    int z = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (z = 0; z < array.GetLength(2); z++)
            {
                if (array[i, j, z] == num)
                {
                    num = new Random().Next(10, 100);
                    num = CheckRepet(array, num);
                }
            }
        }
    }
    return array[i, j, z];
}
int[,,] GetRandomIntArray(int XArray, int YArray, int ZArray)
{
    int[,,] array = new int[XArray, YArray, ZArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = new Random().Next(10, 100);
                array[i, j, z] = CheckRepet(array, array[i, j, z]);

            }
        }
    }
    return array;
}
void PrintIntArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($" {array[i, j, z]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

//----------------------------------
int XArray = Prompt("Введите длинну массива");
int YArray = Prompt("Введите ширину массива");
int ZArray = Prompt("Введите высоту массива");
if (XArray * YArray * ZArray < 90)
{
    int[,,] array = GetRandomIntArray(XArray, YArray, ZArray);
    PrintIntArray(array);
}
else
    Console.WriteLine("Такой массив создать нельзя");

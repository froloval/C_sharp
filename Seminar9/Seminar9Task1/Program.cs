// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого 
// элемента.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintIntArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($" El {i} {j} {z} = {array[i, j, z]}");
            }
            //Console.WriteLine();
        }
        //Console.WriteLine();
    }

}
int[,,] GetRandomIntArray(int XArray, int YArray, int ZArray)
{
    Dictionary<int, string> dict = new Dictionary<int, string>();
    int[,,] array = new int[XArray, YArray, ZArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                int temp = new Random().Next(10, 100);
                while (dict.ContainsKey(temp))
                {
                    temp = new Random().Next(10, 100);
                }
                array[i, j, z] = temp;
                dict.Add(temp, "");
                //bool CheckRepet = false;
                // int temp = 0;
                //while (CheckRepet == false)
                //{

                //Console.Write($" {array[i, j, z]} ");
                //CheckRepet = (array, temp, i, j, z);

                //}
                //array[i, j, z] = temp;
            }
        }
    }
    return array;
}
//------------------------------------------
int XArray = Prompt("Введите длинну массива");
int YArray = Prompt("Введите ширину массива");
int ZArray = Prompt("Введите высоту массива");
if (XArray * YArray * ZArray < 90)
{
    int[,,] array = GetRandomIntArray(XArray, YArray, ZArray);
    PrintIntArray(array);
}
else
{
    Console.WriteLine("Такой массив создать нельзя");
}

Console.WriteLine("Hello, World!");

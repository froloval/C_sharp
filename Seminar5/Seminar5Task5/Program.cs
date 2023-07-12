// Напишите программу, которая находит 
// произведение пар крайних чисел в 
// массиве ()

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] GetRandomIntArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 9);
    }
    return array;
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

//------------------------------
int size = Prompt("Введите размер массива");
int[] array = GetRandomIntArray(size);
PrintIntArray(array);
if (size % 2 == 0)
{
    Console.WriteLine(size / 2);
    int[] ResultArray = new int[size / 2];
    for (int i = 0; i < size / 2; i++)
    {
        ResultArray[i] = array[i] * array[size - 1 - i];
        //Console.Write($" | {ResultArray[i]} | ");
    }
    PrintIntArray(ResultArray);
}
else
{
    int[] ResultArray = new int[size / 2 + 1];
    for (int i = 0; i < size / 2; i++)
    {
        ResultArray[i] = array[i] * array[size - 1 - i];
        //Console.Write($" | {ResultArray[i]} | ");
    }
    //Console.WriteLine($"index {j}");

    ResultArray[size / 2] = array[size / 2];
    PrintIntArray(ResultArray);
}






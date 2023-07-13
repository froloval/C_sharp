// Напишите программу которая веревернет 
// одномерный массив

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
int[] GetResultIntArray(int[] array)
{
    int[] ResultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        ResultArray[i] = array[array.Length - i - 1];
    }
    return ResultArray;
}
//---------------------------------------
int size = Prompt("Введите размер массива");
int[] array = GetRandomIntArray(size);
PrintIntArray(array);
int[] ResultArray = GetResultIntArray(array);
PrintIntArray(ResultArray);


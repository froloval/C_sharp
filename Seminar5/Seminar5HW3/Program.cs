// Напишите программу, которая находит разность максимального
// и минимального элементов массива
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[] GetRandomIntArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * new Random().Next(2, 9), 2);
    }
    return array;
}
void PrintIntArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
void GetNums(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Разность равна {max - min}  ");
}
//----------------------------
int size = Prompt("Введите размер массива");
double[] array = GetRandomIntArray(size);
PrintIntArray(array);
GetNums(array);


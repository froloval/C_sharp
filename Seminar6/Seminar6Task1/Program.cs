// Задайте массив вещественых чисел.
// Найдите разницу между максимальным и 
// минимальным

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1, 11), 2);
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
//-----------------------------
int size = Prompt("Введите размер массива");
double[] array = GetRandomDoubleArray(size);
PrintIntArray(array);
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }

}
Console.WriteLine($"Разность = {max - min}");

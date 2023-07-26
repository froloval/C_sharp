// Дан одномерный массив целых однозначных чисел 
// (элемент массива содержит число от 1 до 9).
// Ваша задача вывести на экран число, которое
// формируется элементами массива слева-направо + 1.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] GetDoubleArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
double GetNumber(int[] array)
{
    double sum = 0;
    int NumPow = 0;
    for (int i = array.Length - 1; i > -1; i--)
    {
        sum = sum + array[i] * Math.Pow(10, NumPow);
        //Console.WriteLine($"sum = {sum} array[i] = {array[i]} NumPow = {NumPow}");
        NumPow++;
    }
    return sum;
}
//------------------------------------------------------------
int length = Prompt("Введите длинну массива");
int[] array = GetDoubleArray(length);
PrintIntArray(array);
double sum = GetNumber(array);
Console.WriteLine($"Ответ {sum + 1}");

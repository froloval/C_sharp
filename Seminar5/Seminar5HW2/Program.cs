// Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на 
//нечётных позициях.

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
void GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма равна {sum}");
}
//----------------------------
int size = Prompt("Введите размер массива");
int[] array = GetRandomIntArray(size);
PrintIntArray(array);
GetSum(array);


// Напишите программу, которая выводит
// массив из N чисел фибаначи

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
//---------------------------------------
int size = Prompt("Введите число ");
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}
PrintIntArray(array);


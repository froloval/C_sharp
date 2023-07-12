// Напишите программу, которая определяет
//присутствует ли заданное число в массиве

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
//--------------------------
int size = 12;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($" {array[i]}");
}
Console.WriteLine();
int num = Prompt("Введите искомое число");
bool result = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        result = true;
    }
}

if (result == true)
{
    Console.WriteLine("Присутствует");
}
else
{
    Console.WriteLine("Отсутствует");
}

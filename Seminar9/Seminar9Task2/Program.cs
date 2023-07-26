// Поиск факториала рекурсивный

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetRecFacktorial(int num)
{
    if (num == 1)
    {
        return 1;
    }
    int temp = num * GetRecFacktorial(num - 1);
    return temp;
}
//----------------------------------
int num = Prompt("Введите число");
Console.WriteLine($"Факториал числа {num} = {GetRecFacktorial(num)}");

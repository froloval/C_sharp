// Напишите программу, которая выводит
// таблицу квадратов от 1 до N

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetSqrt(int N)
{
    for (int i = 1; i < N + 1; i++)
        Console.WriteLine($" {i * i}");
}
//-----------------------------------
int N = Prompt("Введите число");
GetSqrt(N);


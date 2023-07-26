// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetRecSum(int num)
{
    if (num / 10 == 0)
    {
        return num % 10;
    }
    int sum = num % 10 + GetRecSum(num / 10);
    return sum;
}
//----------------------------------
int num = Prompt("Введите число");
Console.WriteLine($"Сумма цифр числа {num} = {GetRecSum(num)}");

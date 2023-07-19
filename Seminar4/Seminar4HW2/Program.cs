// Напишите программу, которая выводит
// сумму всех цифр введенного числа

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetSum(int num)
{
    int sum = num % 10;
    while (num / 10 > 0)
    {
        num = num / 10;
        sum = sum + (num % 10);
        Console.WriteLine(sum);
    }
    return sum;
}
//---------------------------------
int num = Prompt("Введите число ");
Console.WriteLine($"Сумма всех цифр числа = {GetSum(num)}");
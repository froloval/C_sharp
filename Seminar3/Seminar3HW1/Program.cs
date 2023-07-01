// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно 
// палиндромом

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int ComparisonParts(int num)
{
    int index = 1;
    int numLength = num;
    double result = 0;
    while (numLength / 10 != 0)
    {
        numLength = numLength / 10;
        //Console.WriteLine(numLength);
        index++;
    }
    while (index > 0)
    {
        result = result + Math.Pow(10, index - 1) * (num % 10);
        //Console.WriteLine($"result = {result}");
        num = num / 10;
        index = index - 1;
    }
    int res = Convert.ToInt32(result);
    return res;
}
//--------------------------

int num = Prompt("Ввудите пятизначное число");
if (num > 99999 || num < 10000)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    int reversnum = ComparisonParts(num);
    //Console.WriteLine($"reversnum = {reversnum}");
    if (num == reversnum)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

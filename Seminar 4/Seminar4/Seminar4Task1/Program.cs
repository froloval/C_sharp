// Напишете программу, которая проверяет
// является ли введенное пятизначное 
// число палиндромом

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetPalindrom(int num)
{
    int numLength = num;
    int index = 0;
    int result = 0;
    while (numLength != 0)
    {
        result = result * 10 + numLength % 10;
        numLength = numLength / 10;
        Console.WriteLine(numLength);
    }
    return result;
}

//--------------------------------
int num = Prompt("Введите целое число");
int RevNum = GetPalindrom(num);
if (num == RevNum)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}



// Напишите программу, которая выводит 
// количество цифр в веденном числе

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int numLength(int num)
{
    int numLength = num;
    int index = 0;
    while (numLength != 0)
    {
        index++;
        numLength = numLength / 10;
        //Console.WriteLine(numLength);
    }
    return index;
}
//--------------------------
int num = Prompt("Введите число");
Console.WriteLine($"Количество цифр: {numLength(num)}");

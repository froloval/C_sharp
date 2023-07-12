//Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CheckRemainder(int num)
{
    int result = num % 2;
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");

    }
}

//--------------------------------
int num = Prompt("Введите число ");
string result = "";
int i = 0;

while (num != 0)
{
    int Remainder = num % 2;
    result = Remainder + result;
    num = num / 2;
    Console.WriteLine(result);
}


//Console.WriteLine("Hello, World!");

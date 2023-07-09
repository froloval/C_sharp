// Задача 28: Напишите программу, 
// которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetFactorial(int N)
{
    if (N > 1) return N * GetFactorial(N - 1);
    else return 1;
}

int N = Prompt("Введите число: ");
int Fack = GetFactorial(N);
Console.WriteLine("Произведение чисел " + Fack);
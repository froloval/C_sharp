// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetDegree(int num, int degree)
{
    if (degree == 0) return 1;
    int NumDegree = num * GetDegree(num, degree - 1);
    return NumDegree;
}
//-----------------------
int num = Prompt("Введите число");
int degree = Prompt("Введите степень");
Console.WriteLine($" {num} в степени {degree} = {GetDegree(num, degree)}");

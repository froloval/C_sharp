// Напишите программу, которая взводит 
// число А в натуральную степеть В

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int CheckDegree(int degree)
{
    if (degree < 0)
    {
        degree = Prompt("Введенное число не является натуральным. Введите другое число ");
        degree = CheckDegree(degree);
    }
    //Console.WriteLine(degree);
    return degree;
}
double GetDegree(int num, int degree)
{
    double NewNum = Math.Pow(num, degree);
    //Console.WriteLine(NewNum);
    return NewNum;
}
//-------------------------
int num = Prompt("Введите число ");
int degree = Prompt("Введите степень ");
degree = CheckDegree(degree);
double NumDegree = GetDegree(num, degree);
Console.WriteLine($"Число {num} в степени {degree} равно {NumDegree}");

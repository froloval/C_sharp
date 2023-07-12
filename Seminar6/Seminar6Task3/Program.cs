// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool CheckSide(int x, int y, int z)
{
    bool result = false;
    if (x + y > z)
    {
        result = true;
    }
    return result;
}
//-----------------------------------
int x = Prompt("Введите число ");
int y = Prompt("Введите число ");
int z = Prompt("Введите число ");
bool result = CheckSide(x, y, z);
result = result && CheckSide(y, z, x);
result = result && CheckSide(z, x, y);
if (result == true)
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Не может");
}

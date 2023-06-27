// ДОМАШНЕЕ ЗАДАНИЕ
//напишите программу, котрая определяет 
//четность числа
Console.WriteLine("ведите число");
int num = int.Parse(Console.ReadLine());
if (num % 10 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}

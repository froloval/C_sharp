// Напишите программу, которая принимает 
// цифру обозначающую день недели и 
// определяет, является ли тот выходным
Console.WriteLine("Введите число");
int dat = int.Parse(Console.ReadLine());
if ((dat < 1) || (dat > 7))
{
    Console.WriteLine("Такого дня нет");
}
else if (dat > 5)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
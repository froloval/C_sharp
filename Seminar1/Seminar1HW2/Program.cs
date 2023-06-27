// ДОМАШНЕЕ ЗАДАНИЕ
//составьте программу, определяющую большее из 
//трех введенных чисел
Console.WriteLine("ведите два числа");
int max = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > max && num1 > num2)
{
    max = num1;
}
if (num2 > max)
{
    max = num2;
};
Console.WriteLine($"максимальное число {max}");

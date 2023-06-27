// ДОМАШНЕЕ ЗАДАНИЕ
//составьте программу, определяющую большее из 
//двух введенных чисел
Console.WriteLine("ведите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int max;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
};
Console.WriteLine($"максимальное число {max}");

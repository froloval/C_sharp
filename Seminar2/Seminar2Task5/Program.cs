// напишите программу, которая получает 
// два числа и определяет, является ли
// одно из них квадратом другого
Console.WriteLine("Введите два числа");
int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());
int num = 0;
if (num_1 < num_2)
{
    num = num_1;
    num_1 = num_2;
    num_2 = num;
}
if (num_1 == num_2 * num_2)
{
    Console.WriteLine($"Число {num_1} является квадраом числа {num_2}");
}
else
{
    Console.WriteLine($"Число {num_1}  не является квадраом числа {num_2}");
}

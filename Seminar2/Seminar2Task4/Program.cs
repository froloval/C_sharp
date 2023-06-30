// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
Console.Write("Введите число: ");
int num_1 = int.Parse(Console.ReadLine());

if (num_1 % 7 == 0 && num_1 % 23 == 0)
    Console.Write("Кратно");
else
    Console.Write("Не кратно");

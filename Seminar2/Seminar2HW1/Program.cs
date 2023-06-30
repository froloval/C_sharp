// Напишите прграмму, которая приимает 
// на вход трехзначное число и показывает
// вторую цифру данного числа
Console.WriteLine("Введите трехзначное число!");
int num = int.Parse(Console.ReadLine());
if ((num > 999) && (num < 100))
{
    Console.WriteLine("Данное число не является трехзначным");
}
else
{
    num = num / 10;
    num = Math.Abs(num % 10);
    Console.WriteLine($"Вторая цифра равнв {num}");
}

//напишите программу, котораЯ на вход принимает
// число и выдает его квадрат в том случае, 
//если число больше 10
Console.WriteLine("‚ведите число");
int num = int.Parse(Console.ReadLine());
int resalt = num * num;
if (num > 10)
{ Console.WriteLine($"квадрат числа = {resalt}"); }
else
{ Console.WriteLine("введенное число меньше десЯти"); };

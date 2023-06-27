// напишите программу, котораЯ на вход принимает
// два числа и определЯет, ЯвлЯетсЯ ли первое 
//квадратом второго
Console.WriteLine("‚ведите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
num2 = num2 * num2;
if (num1 == num2)
{ Console.WriteLine("число ЯвлЯетсЯ квадратом"); }
else
{ Console.WriteLine("число не ЯвлЯетсЯ квадратом"); }

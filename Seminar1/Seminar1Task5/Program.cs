// напишите программу, котораЯ показывает
// последнюю цифру введенного
// трехзначного чиса

Console.WriteLine("‚ведите трехзначное число");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("число не ЯвлЯетсЯ трехзначным");
}
else
{ Console.WriteLine($"последнЯЯ цифра равна {num % 10}"); }


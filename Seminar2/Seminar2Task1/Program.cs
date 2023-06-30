// напишите программу которая выводит 
//наибольшую цифру введенного двузначного
// числа
int num = new Random().Next(10, 100);
Console.WriteLine($"число {num}");
if (num % 10 > num / 10)
{
    Console.WriteLine($"наибольшее цифра {num % 10}");
}
else
{
    Console.WriteLine($"наибольшее цифра  {num / 10}");
};


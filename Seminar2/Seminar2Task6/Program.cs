// напишите программу которая на вход
// получает произвольное целое число 
// и выводит его зеркально
Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine());
int numLength = num;
int index = 1;
double result = 0;
while (numLength / 10 != 0)
{
    numLength = numLength / 10;
    Console.WriteLine(numLength);
    index++;
}
Console.WriteLine($" В числе {index} цифр");
while (index > 0)
{
    result = result + Math.Pow(10, index - 1) * (num % 10);
    Console.WriteLine(result);
    num = num / 10;
    index = index - 1;
}
Console.WriteLine($"обратный порядок: {result}");



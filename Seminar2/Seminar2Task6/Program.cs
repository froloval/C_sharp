// напишите программу которая на вход
// получает произвольное целое число 
// и выводит его зеркально
Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine());
int numLength = num;
int index = 1;
int result = 0;
while (numLength / 10 != 0)
{
    numLength = numLength / 10;
    Console.WriteLine(numLength);
    index++;
}
Console.WriteLine($" В числе {index} цифр");
while (0 < index)
{
    result = result + Math.Pow((num % 10), index);
    Console.WriteLine(result);
    num = num / 10;
    index--;
}
Console.WriteLine(result);


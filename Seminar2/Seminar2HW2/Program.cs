// Напишите программу, котрая выводит 
// третью цифру заданного числа
// или сообщает, что ее нет
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int numRes = Math.Abs(num);
if (numRes < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры");
}
else
{
    while (numRes > 999)
    {
        numRes = numRes / 10;
    }
    numRes = numRes % 10;
    Console.WriteLine($"Третья цифра равна {numRes}");
}

// напишите программу, которая будет выводить
//все числа, кратные 2 от 0 до введенного числа.
Console.WriteLine("ведите число");
int num = int.Parse(Console.ReadLine());
int i = 0;
while (i < num)
{
    Console.WriteLine($"{i}  ");
    i = i + 2;
}

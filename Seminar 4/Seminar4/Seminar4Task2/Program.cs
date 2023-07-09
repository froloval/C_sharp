// Напишите программу, которая выводит 
// сумму всех чисел от 1 до введенного

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}
//--------------------------------------

int sum = GetSum(limit: 4);
Console.WriteLine(sum);

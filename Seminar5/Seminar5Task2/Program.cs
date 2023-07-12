// Напишите программу замена элементов массива: 
//положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int size = 12;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($" {array[i]}");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}

// Задайте массив из 123 случайных чисел.
// Найдите количество элементов массива <99 // и >10

int size = 12;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 200);
    Console.Write($" {array[i]}");
}
Console.WriteLine();

int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] > 10) && (array[i] < 99))
    {
        quantity++;
        //Console.WriteLine(array[i]);
    }
}

Console.WriteLine($"Количество элементов {quantity}");

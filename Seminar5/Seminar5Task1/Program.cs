// Задайте массив заполненый случайными 
// элементами [-9,9]. Найдите сумму
// отрицательных и положительных элементов 
// массива

int size = 12;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.WriteLine($" {array[i]}");
}

int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
        sumPositive = sumPositive + array[i];
    else
        sumNegative = sumNegative + array[i];
}

Console.WriteLine($"Сумма положительных чисел {sumPositive}. Сумма отрицательных чисел {sumNegative}");

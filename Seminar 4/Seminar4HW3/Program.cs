// Напишите программу, 
// которая выводит массив из 8 элементов.
void PrintArray(int[] mas)
{

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 20);
        Console.Write(" " + mas[i]);
    }
}
//----------------------
int[] mas = new int[8];
PrintArray(mas);
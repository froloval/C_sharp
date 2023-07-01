// Напишите программу, которая по номеру
// четверти показывает диаппазон возможных
// координат
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void GetArea(int num)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("Координаты: х>0 y>0");
            break;
        case 2:
            Console.WriteLine("Координаты: х<0 y>0");
            break;
        case 3:
            Console.WriteLine("Координаты: х<0 y<0");
            break;
        case 4:
            Console.WriteLine("Координаты: х<0 y<0");
            break;
        default:
            Console.WriteLine("Некорректное значение");
            break;
    }
}

//---------------------------------------
int num = Prompt("Введите номер четверти ");
GetArea(num);


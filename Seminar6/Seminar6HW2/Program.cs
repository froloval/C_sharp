// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
//--------------------
double b1 = Prompt("Введите b1");
double k1 = Prompt("Введите k1");
double b2 = Prompt("Введите b2");
double k2 = Prompt("Введите k2");
double x = Math.Round(((b2 - b1) / (k1 - k2)), 3);
double y1 = Math.Round((k1 * x + b1), 3);
double y2 = Math.Round((k2 * x + b2), 3);
Console.WriteLine($"Координаты точки {x} {y1}");
Console.WriteLine($"Координаты точки {x} {y2}");


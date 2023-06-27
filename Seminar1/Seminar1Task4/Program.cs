// напишите программу, котораЯ будет называть 
//дни недели по введенному числу;
Console.WriteLine("‚ведите число");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{ Console.WriteLine("понедельник"); }
if (num == 2)
{ Console.WriteLine("вторник"); }
if (num == 3)
{ Console.WriteLine("среда"); }
if (num == 4)
{ Console.WriteLine("четверг"); }
if (num == 5)
{ Console.WriteLine("пЯтница"); }
if (num == 6)
{ Console.WriteLine("суббота"); }
if (num == 7)
{ Console.WriteLine("воскресенье"); }
if (num > 7 || num < 1)
{ Console.WriteLine("такого днЯ не существует"); }

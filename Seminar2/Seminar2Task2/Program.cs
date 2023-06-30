//Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Изначальное число {randomNumber} ");
int num_1 = randomNumber / 100;
int num_2 = randomNumber % 10;
Console.WriteLine($"Итого: {num_1 * 10 + num_2}");

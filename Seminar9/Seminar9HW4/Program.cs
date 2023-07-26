// Даны два положительных целых числа, представленных в виде строк. 
// Необходимо получить сумму чисел, которые представлены этими строками. 
// Причем полученная сумма должна быть преобразована в строку.
// Для решения этой задачи запрещено преобразовывать входные строки 
// сразу напрямую в целое число при помощи встроенной функции. 
// Необходимо сделать это самостоятельно.

string PromptString(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}
int[] GetIntArray(char[] array)
{
    int[] ResultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == '0')
        {
            ResultArray[i] = 0;
        }
        else if (array[i] == '1')
        {
            ResultArray[i] = 1;
        }
        else if (array[i] == '2')
        {
            ResultArray[i] = 2;
        }
        else if (array[i] == '3')
        {
            ResultArray[i] = 3;
        }
        else if (array[i] == '4')
        {
            ResultArray[i] = 4;
        }
        else if (array[i] == '5')
        {
            ResultArray[i] = 5;
        }
        else if (array[i] == '6')
        {
            ResultArray[i] = 6;
        }
        else if (array[i] == '7')
        {
            ResultArray[i] = 7;
        }
        else if (array[i] == '8')
        {
            ResultArray[i] = 8;
        }
        else if (array[i] == '9')
        {
            ResultArray[i] = 9;
        }
        else
        {
            Console.WriteLine("Вы вели некорректное число");

        }
    }
    return ResultArray;
}
double GetNumber(int[] array)
{
    double sum = 0;
    int NumPow = 0;
    for (int i = array.Length - 1; i > -1; i--)
    {
        sum = sum + array[i] * Math.Pow(10, NumPow);
        //Console.WriteLine($"sum = {sum} array[i] = {array[i]} NumPow = {NumPow}");
        NumPow++;
    }
    return sum;
}
double GetDoubleIntoString(string CharString)
{
    char[] CharArray = CharString.ToCharArray();
    int[] array = GetIntArray(CharArray);
    double result = GetNumber(array);
    return result;
}
//-----------------------------
string string1 = PromptString("Введите число");
double num1 = GetDoubleIntoString(string1);
string string2 = PromptString("Введите число");
double num2 = GetDoubleIntoString(string2);
double sum = num1 + num2;
string str = Convert.ToString(sum);
Console.WriteLine(str);

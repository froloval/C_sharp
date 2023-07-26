// Дана строка, содержащая только следующие 
// символы:'(', ')', '{', '}', '[', ']'. 
// Определите, является ли ваша строка допустимой.
// Исходная строка считается допустимой при условии:
// 1. Открытые скобки должны быть закрыты скобками того же типа.
// 2. Открытые скобки должны быть закрыты в правильном порядке.
// 3.Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

string PromptString(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

/*char[] GetCharArray(char Length)
{
    char[] array = new char(Legth);
    //for (int i = 0; i < array.Length; i++)
    //{
    //     bool CorrectNum = false;
    //   while (CorrectNum = false)
    // {
    //    char temp = Prompt("Введите один из символов: ( , ) , { , } , [ , ]");
    //
    //  if (temp == '(' || temp == '{' || temp == '[' || temp == ')' || temp == '}' || temp == ']')
    //{
    //  array[i] = temp;
    //CorrectNum = true;
    //}
    //else
    //{
    //    Console.WriteLine("Введите другой символ");
    //}
    //}
    //}
    return array;
}
*/
bool CheckString(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {

        if (array[1, i] - 3 < 0)
        {
            int StartSubsequence = SerchStartSubsequence(array, i);
            if (StartSubsequence < 0 || array[1, i] != array[1, StartSubsequence] - 3)
            {
                return false;
            }
        }
    }
    return true;
}
int SerchStartSubsequence(int[,] array, int index)
{
    for (int i = index - 1; i > -1; i--)
    {
        if (array[0, i] == array[0, index])
        {
            return i;
        }
    }
    return -1;
}
int[,] ExchangeCharToInt(char[] array)
{
    int CharLevel = 0;
    int[,] ResultArray = new int[2, array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == '(')
        {
            CharLevel++;
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 4;
        }
        else if (array[i] == '{')
        {
            CharLevel++;
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 5;
        }
        else if (array[i] == '[')
        {
            CharLevel++;
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 6;
        }
        else if (array[i] == ')')
        {
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 1;
            CharLevel--;
        }
        else if (array[i] == '}')
        {
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 2;
            CharLevel--;
        }
        else
        {
            ResultArray[0, i] = CharLevel;
            ResultArray[1, i] = 3;
            CharLevel--;
        }
    }
    return ResultArray;
}
void PrintInt2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//-------------------------------------
string CharString = PromptString("Строку");

char[] CharArray = CharString.ToCharArray();
int[,] IntArray = ExchangeCharToInt(CharArray);
PrintInt2Array(IntArray);
if (CheckString(IntArray))
{
    Console.WriteLine("Допустима");
}
else
{
    Console.WriteLine("Неопустима");
}
/*//if (length % 2 == 0)
{
    char[] CharArray = GetCharArray(length);
    int[,] IntArray = ExchangeCharToInt(CharArray);
    PrintInt2Array(IntArray);

    Console.WriteLine("Hello, World!");
}
else
{
    Console.WriteLine("Строка недопустима!");
}
*/
Console.WriteLine("Hello, World!");

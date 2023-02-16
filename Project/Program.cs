
// Метод заполнения массива
string[] ArrayCompletion(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Console.ReadLine()!;
        if (Array[i] == "")
        {
            Array[i] = Console.ReadLine()!;
        }
    }
    Console.WriteLine(string.Join(", ", Array));
    ArrayTransformation(Array);
    return Array;
}

// Метод преоразования массива
void ArrayTransformation(string[] Array)
{
    string[] ArrayNow = new string[new Random().Next(1, 3)];
    for (int j = 0; j < ArrayNow.Length; j++)
    {
        ArrayNow[j] = Array[new Random().Next(0, 3)];
    }
    Console.WriteLine(string.Join(", ", ArrayNow));
}

// Вход в программу
Console.WriteLine("Программа формирования нового массива строк");
string[] Array = new string[3];
ArrayCompletion(Array);

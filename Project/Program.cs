﻿
// Метод заполнения массива
string[] ArrayCompletion(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Array[{i + 1}]: ");
        Array[i] = Console.ReadLine()!;
        do
        {
            if (Array[i] == "")
            {
                Console.Write($"Array[{i + 1}]: ");
                Array[i] = Console.ReadLine()!;
            }
        }
        while (Array[i] == "");
    }
    Console.WriteLine();
    Console.Write("Вы заполнили массив следующими данными: ");
    Console.WriteLine(string.Join(", ", Array));
    Console.Write("Желайте изменить введенные данные?: (yes/no) ");
    if (Console.ReadLine()! == "yes")
    {
        ArrayCompletion(Array);
    }
    else
    {
        Console.WriteLine();
        Console.Write("Нажмите Enter для продолжения: ");
        Console.ReadKey();
        ArrayTransformation(Array);
    }
    return Array;
}

// Метод преоразования массива
void ArrayTransformation(string[] Array)
{
    string[] ArrayNow = new string[new Random().Next(1, 4)];
    for (int j = 0; j < ArrayNow.Length; j++)
    {
        ArrayNow[j] = Array[new Random().Next(0, 5)];
    }
    Console.WriteLine();
    Console.Write("Новый массив строк: ");
    Console.WriteLine(string.Join(", ", ArrayNow));
}

// Вход в программу
Console.WriteLine("Программа формирования нового массива строк");
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadKey();
Console.WriteLine();
string[] Array = new string[5];
ArrayCompletion(Array);

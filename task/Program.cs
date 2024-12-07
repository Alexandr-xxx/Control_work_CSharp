﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Решение.
// Длина нового массив (array2) равна количеству строк из первого массива (arrayINput)
// с длинной не более 3-х элементов.

Console.WriteLine("Введите строки (через пробел!): ");
string str = Console.ReadLine();

string[] arrayInput = str.Split();

int GetTheCountOfRowsInAnArrayOfThreeOrFewerElements(string[] array1)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

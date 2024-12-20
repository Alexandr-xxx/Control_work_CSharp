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

string[] GetArrayOfRowesOfThreeOrFewerElements(string[] array, int size)
{
    string[] array2 = new string[size];
    int sizeArr2 = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[sizeArr2] = array[i];
            sizeArr2++;
        }
    }
    return array2;
}

void ShowArrayOfRowesOfThreeOrLessElements(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}

Console.WriteLine("Введите строки (через пробел!): ");
string str = Console.ReadLine();

string[] arrayInput = str.Split();

int sizeRes = GetTheCountOfRowsInAnArrayOfThreeOrFewerElements(arrayInput);
string[] arrayResult = GetArrayOfRowesOfThreeOrFewerElements(arrayInput, sizeRes);

Console.WriteLine("Новый (сформированный) массив строк из трех и менее элементов: ");
ShowArrayOfRowesOfThreeOrLessElements(arrayResult);
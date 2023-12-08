/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] arrayOfStrings = {"Hello", "2", "world", ":-)"}; 

string[] ArraySortByLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        string prefix = ", ";

        if(i == array.Length -1)
        {
            prefix = "";
        }
        System.Console.Write($"\"{array[i]}\"{prefix}");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}

PrintArray(arrayOfStrings);
string[] result = ArraySortByLength(arrayOfStrings);
PrintArray(result);
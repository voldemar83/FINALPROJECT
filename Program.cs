/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Clear();

string[] arr = {"hello", "ok?", "bye"}; // Задали 1 массив строк

string[] arr1 = new string[arr.Length]; // Задали 2 массив соразмерный длине 1му, для хранения корректных значений

int count = 0; // Переменная счетчик значения

for (int i = 0; i < arr.Length; i++) // Цикл счетчик
{
    if(arr[i].Length <= 3)
    {
    arr1[count] = arr[i];
    count++;
    }
}

for (int i = 0; i < arr1.Length; i++) // Выводим результат в консоль
{
    Console.Write($"{arr1[i]} ");
}

Console.WriteLine();

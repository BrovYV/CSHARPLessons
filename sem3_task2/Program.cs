﻿// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные 
// элементы на положительные, а положительные на отрицательные.
// Пример

// [1 -5 6]
// => [-1 5 -6]




int[] arr = new int[10] { -10, 3, 4, 19, 3, -5, -4, -9, -3, -1 };

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write(arr[i] + " ");
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

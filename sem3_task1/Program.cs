﻿// Задайте массив. Напишите программу, которая определяет, 
// присутствует  ли  заданное  число  в  массиве. 
// Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да




//1.Получаем/задаем исходные данные
int[] arr = new int[] { 1, 3, 4, 19, 3 };
int num = 4;

//2. Проверка исходных данных (при необходимости)

//3. Реализация логики алгоритма

bool res = false;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == num)
    {
        res = true;
        break;
    }
}


//4. Вывод результата

Console.WriteLine(res ? "Да" : "Нет");






// //int[] array = new int[6]{1, 3, 4, 19, 3, 8};

// // 1. Получаем/задаём исходные данные
// int[] array = {1, 3, 4, 19, 3, 8};
// int num = 9;

// // int[] arr = new int[3];
// // for (int i = 0; i < arr.Length; i++)
// // {
// //     Console.Write($"Введите {i + 1} элемент: ");
// //     arr[i] = Convert.ToInt32(Console.ReadLine());
// // }

// // 2. Проверка исходных данных (при необходимости)

// // 3. Реализация логики (алгоритм)
// bool res = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] == num) 
//     {
//         res = true;
//         break;
//     }
// }

// // 4. Вывод результата
// Console.WriteLine(res ? "Да" : "Нет");
﻿// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]
// (элемент 7 не имеет пары)




int[] arr = { 1, 3, 2, 4, 2, 3 };
int size = arr.Length / 2;

int[] result = new int[size];

for (int i = 0; i < result.Length; i++)
{
    result[i] = arr[i] * arr[arr.Length - 1 - i];

}
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

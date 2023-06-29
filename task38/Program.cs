﻿/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

class Program
{
    static void Main()
    {
        Console.Clear();
		// Задаем массив вещественных чисел
        double[] array = { 0.2, 3.22, 4.2, -4.22, 1.15, 77.15, 65.2, 150, 2.56, 250};

        // Находим максимальный и минимальный элементы в массиве
        double max = array[0];
        double min = array[0];
        foreach (var num in array)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double diff = max - min;

        // Выводим разницу между максимальным и минимальным элементами
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    }
}
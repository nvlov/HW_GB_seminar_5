/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
	Console.Write("Введите количество элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();
    int[] arr = new int[n];

    // Заполняем массив случайными положительными трёхзначными числами
    for (int i = 0; i < n; i++) {
      arr[i] = rnd.Next(100, 1000);
    }

    Console.Write("Массив: ");
    PrintArray(arr);

    int countEven = CountEvenNumbers(arr);
    Console.WriteLine("Количество чётных чисел: " + countEven);
  }

  // Метод для вывода массива на экран
  public static void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
      Console.Write(arr[i]);

      if (i != arr.Length - 1) {
        Console.Write(", ");
      }
    }
    Console.WriteLine("]");
  }

  // Метод для подсчета количества четных чисел в массиве
  public static int CountEvenNumbers(int[] arr) {
    int count = 0;

    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] % 2 == 0) {
        count++;
      }
    }

    return count;
  }
}

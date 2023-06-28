/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Пример:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
	Console.Write("Введите количество элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();
    int[] arr = new int[n];

    // Заполняем массив случайными числами
    for (int i = 0; i < n; i++) {
      arr[i] = rnd.Next(-100, 101);
    }

    Console.Write("Массив: ");
    PrintArray(arr);

    int sum = SumOddElements(arr);
    Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
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

  // Метод для подсчета суммы элементов на нечетных позициях
  public static int SumOddElements(int[] arr) {
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2) {
      sum += arr[i];
    }

    return sum;
  }
}

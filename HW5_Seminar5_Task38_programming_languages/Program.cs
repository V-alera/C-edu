/*
Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
*/

using System;

namespace HW5_Seminar5_Task34_programming_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double diff = 0.0, min = 0.0, max = 0.0;
            Console.Write("Введите количество элементов массива: ");
                int size = int.Parse(Console.ReadLine());
                    double[] mass = new double[size];

            Console.Write($"Введите массив вещественных чисел, состоящий из {size} элементов: ");
            Console.WriteLine();
            min = mass[0];
            max = mass[0];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i}: ");
                mass[i] = double.Parse(Console.ReadLine());
                if (min > mass[i]) min = mass[i];
                if (max < mass[i]) max = mass[i];
            }
            Console.WriteLine();
            Console.Write($"Разница между максимальным и минимальным элементом равна {max-min} ");
            Console.WriteLine();
        }
    }
}
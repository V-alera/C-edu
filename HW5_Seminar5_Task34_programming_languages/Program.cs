/*
Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
*/

using System;

namespace HW5_Seminar5_Task34_programming_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int evenNumberCount = 0;
            Console.Write("Введите количество элементов массива: ");
                int size = int.Parse(Console.ReadLine());
                    int[] mass = new int[size];

                    var newRnd = new Random();
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                mass[i] = newRnd.Next(100, 999);
                Console.Write(mass[i] + " ");
                if (mass[i] % 2 == 0) evenNumberCount++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"В массиве {evenNumberCount} четных элементов ");
            Console.WriteLine();
        }
    }
}

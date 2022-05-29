/*
Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
*/

using System;

namespace HW5_Seminar5_Task34_programming_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int sumOddElement = 0;
            Console.Write("Введите количество элементов массива: ");
                int size = int.Parse(Console.ReadLine());
                    int[] mass = new int[size];

                    var newRnd = new Random();
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                mass[i] = newRnd.Next(-100, 100);
                Console.Write(mass[i] + " ");
                if (i % 2 != 0) sumOddElement+=mass[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Сумма элементов на нечетных местах равна {sumOddElement} ");
            Console.WriteLine();
        }
    }
}

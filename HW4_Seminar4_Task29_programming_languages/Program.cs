/*
Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System;

namespace HW4_Seminar4_Task29_programming_languages
{
    class Program
    {
           
        static void Main(string[] args)
        {
            Console.Clear();
                Console.WriteLine ("Какое количество элементов планируется в массиве?");
                    int num = int.Parse(Console.ReadLine());
                Console.WriteLine ("Инициализируем массив");    
                    int[] mass = new int [num];
                Console.WriteLine ("Заполняем массив в случайном порядке");
                    for (int i = 0; i < num; i++)
                       {
                            mass[i] = new Random().Next(-100, 100);
                       }

                            Console.Write (" Mass = {");
                    for (int i = 0; i < num; i++)
                       {
                            if (i == num-1) Console.Write($" {mass[i]} ");
                            else Console.Write($" {mass[i]}, ");
                       }
                            Console.Write ("}");
        }
    }
}

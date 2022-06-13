/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {

        static int[] MassInit (int num)

        {
                int size = 0;

                if (num >= 1) size = num;
                else size = -num + 1;

                int[] Arr = new int [size];

                return Arr;
        }

        static int [] FillArray (int[] Arr, int pos, int N)
        {
                if (N <= 1) 
                {
                    if (N == 0) FillArray (Arr, pos, ++N);
                    Arr[pos] = N;
                    if (N == 1) return Arr;
                    FillArray (Arr, ++pos, ++N);
                }
                else {
                    Arr[pos] = N;
                    if (N == 1) return Arr;
                    FillArray (Arr, ++pos, --N);
                }
                return Arr;
        }

        static void PrintArray (int[] Arr)

        {
                for (int i = 0; i < Arr.Length; i++)
                {
                        if (Arr[i] < 0) Console.Write ("|" + Arr[i] + "| " + "\t");
                        else Console.Write ("| " + Arr[i] + "|" + "\t");
                    }
        }

        static void Main(string[] args)
        {

                Console.Clear();

                int[] Mass = {};
                int pos = 0;
                Console.Write("Введите число N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N <= 0) 
                {
                    Console.Write("Число не натуральное! ");
                    System.Environment.Exit(0);
                    Console.WriteLine();
                }    

                Mass = MassInit (N);

                Mass = FillArray (Mass, pos, N);

                Console.WriteLine();
                Console.Write("Натуральные числа от N -> ");
                PrintArray (Mass);

                Console.WriteLine();                
        }        

    }
}


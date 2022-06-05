/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 m = 3, n = 4.
 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {

        static double[,] MassInit (int rows, int cols)

        {
                double[,] Arr = new double [rows, cols];

                return Arr;
        }

        static double [,] FillArray (double[,] Arr, int rows, int cols)
        {
            System.Random random = new System.Random();
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        Arr[x, y] =  Math.Round((new Random().NextDouble() * 10 - 5), 2);
                    }
                }
                return Arr;
        }

        static void PrintArray (double[,] Arr, int rows, int cols)

        {
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if (Arr[x, y] < 0) Console.Write ("|" + Arr[x, y] + "|" + "\t");
                        else Console.Write ("| " + Arr[x, y] + "|" + "\t");
                    }
                    Console.WriteLine();
                }
        }

        static void Main(string[] args)
        {

                Console.Clear();

                double[,] table = {};
                Console.Write("Введите количество строк: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите введите количество столбцов: ");
                int n = Convert.ToInt32(Console.ReadLine());

                table = MassInit (m, n);

                table = FillArray (table, m, n);

                Console.WriteLine();

                PrintArray (table, m, n);

        }

    }
}


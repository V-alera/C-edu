/* 
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {

        static int[,] MassInit (int rows, int cols)

        {
                int[,] Arr = new int [rows, cols];

                return Arr;
        }

        static int [,] FillArray (int[,] Arr, int rows, int cols)
        {
            Random random = new Random();
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        Arr[x, y] =  random.Next(-20, 20);
                    }
                }
                return Arr;
        }

        static void PrintArray (int[,] Arr, int rows, int cols)

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

        static void GiveAverageValue (int[,] Arr, int row, int col)
        {
            int[] Average = new int [col];
            for (int y = 0; y < col; y++)
            {
                for (int x = 0; x < row; x++)
                {
                   Average[y]+= Arr[x, y];
                }
                Average[y]/=col;
            }
            
            Console.WriteLine("Среднее арифметическое по каждому столбцу: ");

            for (int z = 0; z < col; z++)
            {
                   if (Average[z] < 0) Console.Write("|" + Average[z] + "|" + "\t");
                   else Console.Write ("| " + Average[z] + "|" + "\t");
            }
        }

        static void Main(string[] args)
        {

                Console.Clear();

                int[,] table = {};
                Console.Write("Введите количество строк: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите введите количество столбцов: ");
                int n = Convert.ToInt32(Console.ReadLine());

                table = MassInit (m, n);

                table = FillArray (table, m, n);

                Console.WriteLine();

                PrintArray (table, m, n);

                Console.WriteLine();
                

                //Console.Clear();
                
                GiveAverageValue (table, m, n);

        }

    }
}


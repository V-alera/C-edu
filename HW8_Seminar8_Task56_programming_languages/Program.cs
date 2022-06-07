/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
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

        static void SumArray (int[,] Arr, int row, int col)
        {
            int[] SumRows = new int[row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    SumRows[i]+=Arr[i, j];
                }
            }

            Console.WriteLine();

            int min = SumRows[0];
            int rowNumber = 0;

            for (int i = 0; i < row; i++)
            {
                if (min > SumRows[i])
                { 
                    min = SumRows[i];
                    rowNumber = i;
                    }
            }

            Console.WriteLine($"Минимальное значение суммы {min}, строка {++rowNumber}");
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
                Console.WriteLine("Исходный вид: ");
                PrintArray (table, m, n);

                Console.WriteLine();
                SumArray (table, m, n);

                Console.WriteLine();
                
        }        

    }
}

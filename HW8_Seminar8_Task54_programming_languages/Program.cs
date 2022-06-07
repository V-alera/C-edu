/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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

        static int[,] SortArray (int[,] Arr, int row, int col)
        {
            int min = 0, temp = 0;

            for (int r = 0; r < row; r++)
            {
               for (int c = 0; c < col - 1; c++)
                {
                    min = c;

                    for (int j = c + 1; j < col; j++)
                    {
                        if (Arr[r,j] > Arr[r, min]) min = j;
                    }
                

                    if (min != c)
                    {
                        temp = Arr[r, c];
                        Arr[r, c] = Arr [r, min];
                        Arr [r, min] = temp;
                    }
                }

            }
            return Arr;
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
                Console.WriteLine("Результат сортировки двумерного массива убыванием построчно: ");
                table = SortArray (table, m, n);

                PrintArray (table, m, n);

                Console.WriteLine();
                
        }        

    }
}



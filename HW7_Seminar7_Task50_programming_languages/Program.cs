/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
                        Arr[x, y] =  random.Next(-5, 5);
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

        static void GiveValue (int[,] Arr, int row, int col, int hor, int vert)
        {

            if ((row >= 0 && row < hor) && (col >= 0 && col < vert)) Console.WriteLine($"Строка {row}, столбец {col}, значение: {Arr[row, col]}");
            else Console.WriteLine ("Неправильная позиция");
            
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
                Console.WriteLine("Укажите место в массиве: ");

                Console.Write("Cтрока: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Столбец: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.Clear();
                
                GiveValue (table, x, y, m, n);

        }

    }
}

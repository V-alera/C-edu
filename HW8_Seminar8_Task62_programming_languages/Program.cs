/* 
Задача 62: Заполните спирально массив 4 на 4.
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
                int num = 1;
                
                for (int b = 0; b < cols-1; b++)
                {                   
                        Arr[0, b] =  num;
                        num++;                   
                }

                for (int a = 0; a < rows; a++)
                {                   
                        Arr[a, cols-1] =  num;
                        num++;                   
                }

                for (int b = cols-2; b >= 0; b--)
                {                   
                        Arr[rows-1, b] =  num;
                        num++;                   
                }

                for (int a = rows-2; a > 0; a--)
                {                   
                        Arr[a, 0] =  num;
                        num++;                   
                }

                int numNextRow = 1;
                int numNextCol = 1;

                while (num < rows * cols)
                {
                    while (Arr[numNextRow, numNextCol + 1] == 0) 
                    {
                        Arr[numNextRow, numNextCol] = num;
                        num++;
                        numNextCol++;
                    }

                    while (Arr[numNextRow + 1, numNextCol] == 0) 
                    {
                        Arr[numNextRow, numNextCol] = num;
                        num++;
                        numNextRow++;
                    }

                    while (Arr[numNextRow, numNextCol - 1] == 0) 
                    {
                        Arr[numNextRow, numNextCol] = num;
                        num++;
                        numNextCol--;
                    }

                    while (Arr[numNextRow - 1, numNextCol] == 0) 
                    {
                        Arr[numNextRow, numNextCol] = num;
                        num++;
                        numNextRow--;
                    }
                }
                
                for (int a = 0; a < rows; a++) 
                {
                    for (int b = 0; b < cols; b++) 
                    {
                        if (Arr[a, b] == 0) Arr[a, b] = num;
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
               
                Console.WriteLine();
                
        }        

    }
}



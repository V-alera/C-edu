/* 
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
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
                        Arr[x, y] =  random.Next(0, 7);
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
                        int count = 0;
                        for (int a = 0; a < rows; a++)
                        {
                            for (int b = 0; b < cols; b++)
                            {
                                if (Arr[x, y] == Arr[a, b]) count++;
                            }
                        }    

                        if (Arr[x, y] < 0) Console.Write ($"| Элемент [{x}, {y}]: " + Arr[x, y] + $" N = {count} |" + "\t");
                        else Console.Write ($"| Элемент [{x}, {y}]: " + Arr[x, y] + $" N = {count} |" + "\t");
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
                Console.WriteLine("Результирующий вид: ");
                PrintArray (table, m, n);

                Console.WriteLine();
               
                Console.WriteLine();
                
        }        

    }
}




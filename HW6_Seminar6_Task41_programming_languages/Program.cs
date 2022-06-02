using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {
        static int[,] MassInit (int r, int c)
        {
            
            int[,] table = new int[r,c];
            return table;
        }

        static int[,] FillArray (int[,] mass, int r, int c)

        {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write($"Элемент [{i}, {j}]: ");
                        mass[i, j] = int.Parse(Console.ReadLine());
                    }
                }

            return mass;
        }

        static void PrintArray (int[,] mass, int r, int c)

        {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write(mass[i, j] + " ");
                    }
                    Console.WriteLine();
                }

        }

        static int GetPositive (int[,] mass, int r, int c)
        {
            int res = 0;
            for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (mass[i, j] > 0) res++;
                    }
                    Console.WriteLine();
                }
                return res;
        }

      /* static int GetPositive (int[,] mass, int r, int c, int res, int num)
        {
                    
                    if (r == 0 && c == 0) return res;
                    else if (mass[r-1, c-1] > 0) res++;
                    if (c == 0)
                    {
                        r--;
                        c = num+1;
                        num = -1;
                    }
                    num++;
                    c--;
                        GetPositive(mass, r, c, res, num);
            return res;
        }*/

        static void Main(string[] args)
        {
            int[,] table = {};
            int result = 0, count = 0;
                Console.Write("Введите количество строк двумерного массива = ");
                    int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                
                Console.Write("Введите количество столбцов двумерного массива = ");
                    int cols = int.Parse(Console.ReadLine());
                
                Console.WriteLine("");
                
                Console.WriteLine("Введите элементы двумерного массива: ");

                table = MassInit (rows, cols);
                table = FillArray (table, rows, cols);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Массив имеет вид: ");
                PrintArray(table, rows, cols);  
                result = GetPositive(table, rows, cols);
                Console.WriteLine($"Количество чисел больше 0 равно = {result}");
        }
    }
}

/* 
Задача 58*: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
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

        static void MultiplicationMatrix (int[,] Arr1, int[,] Arr2, int row1, int col1, int row2, int col2)
        {
            int borderRows = 0, borderCols = 0;

            if (row1 > row2 || row1 == row2) borderRows = row1;
            else borderRows = row2;

            if (col1 > col2 || col1 == col2) borderCols = col1;
            else borderCols = col2;

            int[,] ArrRes = new int [borderRows, borderCols];

            for (int i = 0; i < borderRows; i++)
            {
                for (int j = 0; j < borderCols; j++)
                {
                    if (i < row1 && i < row2 && j < col1 && j < col2) ArrRes[i, j] = Arr1[i, j] * Arr2[i, j];
                    else if (i < row1 && j < col1 && i >= row2 || j >= col2) ArrRes[i, j] = Arr1[i, j];
                    else if (i < row2 && j < col2 && i >= row1 || j >= col1) ArrRes[i, j] = Arr2[i, j];
                    else break;
                }
            }

            Console.WriteLine("Результирующий вид: ");

           for (int i = 0; i < borderRows; i++)
            {
                for (int j = 0; j < borderCols; j++)
                {
                    if (ArrRes[i, j] < 0) Console.Write ("|" + ArrRes[i, j] + "|" + "\t");
                    else Console.Write ("| " + ArrRes[i, j] + "|" + "\t");
                }
                Console.WriteLine();
            }

}

        static void Main(string[] args)
        {

                Console.Clear();

                int[,] table1 = {};
                int[,] table2 = {};
                Console.Write("Введите количество строк первой матрицы: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов первой матрицы: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество строк второй матрицы: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов второй матрицы: ");
                int n = Convert.ToInt32(Console.ReadLine());


                table1 = MassInit (a, b);
                table2 = MassInit (m, n);

                table1 = FillArray (table1, a, b);
                table2 = FillArray (table2, m, n);

                Console.WriteLine();
                Console.WriteLine("Исходный вид первой матрицы: ");
                PrintArray (table1, a, b);
                Console.WriteLine("Исходный вид второй матрицы: ");
                PrintArray (table2, m, n);

                Console.WriteLine();
                MultiplicationMatrix (table1, table2, a, b, m, n);

                Console.WriteLine();
                
        }        

    }
}


/* 
Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {

        static int[,,] MassInit (int lines, int rows, int cols)

        {
                int[,,] Arr = new int [lines, rows, cols];

                return Arr;
        }

        static int [,,] FillArray (int[,,] Arr, int lines, int rows, int cols)
        {
            Random random = new Random();

                bool flag = false;

                for (int x = 0; x < lines; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        for (int z = 0; z < cols; z++)
                        {
                            int num = random.Next(40, 100);

                            int k;

                        for (k = 0; k < lines; k++)
                           {
                               int l;
                                for (l = 0; l < rows; l++)
                                {
                                    int m;
                                    for (m = 0; m < cols; m++)
                                    {
                                        if (num == Arr[k, l, m]) {
                                            flag = true;
                                            break;
                                        }
                                        
                                    }
                                }
                           }

                           if (flag != true) Arr[x, y, z] =  num;
                           else --z;
                           flag = false;
                           
                        }
                    }
                }
                return Arr;
        }

        static void PrintArray (int[,,] Arr, int lines, int rows, int cols)

        {
                for (int x = 0; x < lines; x++)
                {
                    Console.WriteLine("Page " + x);
                    for (int y = 0; y < rows; y++)
                    {
                        for (int z = 0; z < cols; z++)
                        { 
                        if (Arr[x, y, z] < 0) Console.Write ($"| Элемент [{x},{y},{z}] " + Arr[x, y, z] + "|" + "\t");
                        else Console.Write ($"| Элемент [{x},{y},{z}] " + Arr[x, y, z] + "|" + "\t");
                        }
                    Console.WriteLine();
                    }
                Console.WriteLine("======================="); 
                }
        }
        
        static void Main(string[] args)
        {

                Console.Clear();

                int[,,] table = {};
                Console.Write("Введите количество строк трехмерного массива: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов трехмерного массива: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество рядов в глубину трехмерного массива: ");
                int a = Convert.ToInt32(Console.ReadLine());

                table = MassInit (a, b, c);
                
                table = FillArray (table, a, b, c);
                
                Console.WriteLine();
                Console.WriteLine("Трехмерный массив имеет вид: ");
                PrintArray (table, a, b, c);
                
                Console.WriteLine();
                                
        }        

    }
}

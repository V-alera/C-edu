/* 
Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника.
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {

        static void Main(string[] args)
        {

                Console.Write("Введите количество строк : ");
                int m = int.Parse(Console.ReadLine());
                       
                int[][] Pascal = new int[m][];

                Pascal[0] = new int[] { 1 };
 

                for (int i = 1; i < Pascal.Length; i++)
                {
                    Pascal[i] = new int[i + 1];  
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            Pascal[i][j] = 1;
                        else
                        {
                            Pascal[i][j] = Pascal[i - 1][j - 1] + Pascal[i - 1][j];
                        }
                    }
                }
 
                for (int i = 0; i < Pascal.Length; i++)
                {
                    for (int j = 0; j < Pascal[i].Length; j++)
                    {
                        Console.Write(Pascal[i][j] + "\t");
                    }
                    Console.WriteLine();
                }
 
                Console.ReadKey();
                
        }        

    }
}

/*
Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;

namespace Seminar_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0, N = 0, stepen = 3;
            Console.WriteLine();
            Console.Write("Введите число ");
                      
            str = Console.ReadLine();
            N = Convert.ToInt32(str);
            int[] arr = new int[N+1];
                for (int i = 1; i <= N; i++)
                {
                arr[i] = Convert.ToInt32(Math.Pow(i, stepen));
                }
            Console.WriteLine();
            Console.Write("Список кубов до числа " + N);    
            Console.Write("-> ");
               for (int i = 1; i <= N; i++)
                {
                Console.Write(arr[i] + " ");
                } 
            
            Console.WriteLine();
                       
        }
    }
}

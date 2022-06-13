/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
        class Program
    {

       public static int GetSum(int S, int L)
        {
            if (L == S) return S;
            else
            {
                return GetSum(S, L - 1) + L;
            }
        }

        static void Main(string[] args)
        {

            Console.Clear();

            int startPos = 0, lastPos = 0, sum = 0;
            Console.Write("Введите число M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M <= 0 || N <= 0)
            {
                Console.Write("Задано ненатуральное число! ");
                System.Environment.Exit(0);
            }
            else if (M == N)
            {
                Console.Write("Ошибка, число M равно N! ");
                System.Environment.Exit(0);
            }

            if (M > N)
            {
                startPos = N;
                lastPos = M;
            }
            else
            {
                startPos = M;
                lastPos = N;
            }

            sum = GetSum(startPos, lastPos);

            Console.WriteLine();
            Console.WriteLine($"Cумма натуральных чисел в промежутке M = {M}; N = {N} -> {sum}");
            
            Console.ReadLine();
        }

    }
}



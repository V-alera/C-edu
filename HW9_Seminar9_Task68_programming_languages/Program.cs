/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
        class Program
    {

       public static int AkkermanFunc(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0 && m > 0) return AkkermanFunc(m - 1, 1);
            else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        }

        static void Main(string[] args)
        {
            int res = 0;
            
            Console.Clear();

            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m <= 0 || n <= 0)
            {
                Console.Write("Отрицательное число! ");
                System.Environment.Exit(0);
            }
                        
            res = AkkermanFunc(m, n);

            Console.WriteLine();
            Console.WriteLine($"A({m},{n}) = {res}");
            
            Console.ReadLine();
        }

    }
}
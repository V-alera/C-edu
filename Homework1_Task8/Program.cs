// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

using System;

namespace Homework1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0, i = 1;
            
            Console.WriteLine("Введите число");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);

            Console.WriteLine();
            Console.Write("Четные числа: ");
            if (num > i)
            {
                while (i != num && i < num)
                {
                    i = i + 1;
                    Console.Write(" " + i + ", ");
                    i++;
                }
            } 

            else
            {
                while (i != num && i > num)
                {
                    i = i - 1;
                    Console.Write(" " + i + ", ");
                    i--;
                }
            }

             Console.WriteLine();

        }
    }
}
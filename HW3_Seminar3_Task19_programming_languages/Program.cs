/*
Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

using System;

namespace Seminar_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0, number = 0, count = 0;
            int []arr = new int[5];
            Console.WriteLine();
            Console.WriteLine("Введите число");
            Console.WriteLine();
        
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            number = num;
                for (int i = 0; i < 5; i++)
                {
                arr[i] = num % 10;
                num /= 10;
                count++;
                }

            if (num != 0 || arr[4] == 0) {
                Console.Write("Число не 5ти значное !");
                Console.WriteLine();
                Environment.Exit(0);
            }

            Console.WriteLine();

            if (arr[0] == arr[4] && arr[1] == arr[3]) Console.Write("Число " + number + " - полиндром");
            else Console.Write("Число " + number + " - не полиндром");
            
            Console.WriteLine();
                       
        }
    }
}


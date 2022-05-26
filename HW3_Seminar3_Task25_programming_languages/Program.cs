/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;


namespace Seminar_Task1
{
    
    class Program
    {
        static int FillDateNumber ()
        {
        Console.Write ("Загадайте число: ");
            int num = int.Parse(Console.ReadLine());
           return num;  
        }

        static int FillDateExponent ()
        {
            Console.Write ("Загадайте степень: ");
            int exp = int.Parse(Console.ReadLine ()); 
            return exp;
        }
        
        static int NumberToExponent(int num, int exp)
        {
            Console.WriteLine ($"Число {num} возведем в степень {exp}");
            int res = (int)Math.Pow (num, exp);
            return res;
        }

        static void PrintResult (int res)
        {
             Console.WriteLine ($"Результат = {res}");
        }
        static void Main(string[] args)
        {
            Console.Clear ();
        int number = FillDateNumber ();
        int exponent = FillDateExponent ();
        int result = NumberToExponent(number, exponent);
            PrintResult(result);
                       
        }
    }
}


// Напишите программу, которая на вход принимает 3 числа и выдает является ли число четным

using System;

namespace Homework1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0;
            
            Console.WriteLine("Введите число");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);

            Console.WriteLine();
            
            if (num%2 == 0) Console.Write("Число " + num + " - четное ");
                else Console.Write("Число " + num + " - нечетное "); 
            
            Console.WriteLine();
        }
    }
}
// Напишите программу, которая на вход принимает 3 числа и выдает максимальное

using System;

namespace Homework1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num1 = 0, num2 = 0, num3 = 0;
            
            Console.WriteLine("Введите число 1 ");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);

            Console.WriteLine();
            
            Console.WriteLine("Введите число 2 ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);
            
            Console.WriteLine();
            
            Console.WriteLine("Введите число 3 ");
            str = Console.ReadLine();
            num3 = Convert.ToInt32(str);

            Console.WriteLine();

            if (num1 > num2 && num1 > num3) Console.Write("Число " + num1 + " - максимальное из чисел ");
               else if (num2 > num1 && num2 > num3) Console.Write("Число " + num2 + " - максимальное из чисел ");
                     else if (num3 > num1 && num3 > num2) Console.Write("Число " + num3 + " - максимальное из чисел ");
                            else Console.Write("Число " + num1 + " равно числу " + num2 + " равно числу " + num3); 
        }
    }
}

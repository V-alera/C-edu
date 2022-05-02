// Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее

using System;

namespace Lesso1_homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num1 = 0, num2 = 0;
            
            Console.WriteLine("Введите число 1 ");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);
            Console.WriteLine();
            Console.WriteLine("Введите число 2 ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);
            
            if (num1 > num2) Console.Write("Число " + num1 + " больше числа " + num2);
               else if (num1 < num2) Console.Write("Число " + num1 + " меньше числа " + num2);
                   else Console.Write("Число " + num1 + " равно числу " + num2); 
        }
    }
}

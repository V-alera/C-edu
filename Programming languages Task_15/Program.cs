/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
Примеры:
6 -> да
7 -> да
1 -> нет */

using System;

namespace Seminar_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int day = 0;
            Console.WriteLine();
            Console.WriteLine("Введите день недели");
            Console.WriteLine();
            
            str = Console.ReadLine();
            if (str == "1" || str == "2" || str == "3" || str == "4" || str == "5" || str == "6" || str == "7") day = Convert.ToInt32(str);
            Console.WriteLine();
            
            if (day > 5 && day < 8) Console.Write("Это выходной день!");
            else if (str == "суббота" || str == "воскресенье") Console.Write("Это выходной день!");
            else Console.Write("Рабочий день!");
            Console.WriteLine();
        }
    }
}


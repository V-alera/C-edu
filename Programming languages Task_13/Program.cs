/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
Примеры:
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

using System;

namespace Seminar_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0;
            Console.WriteLine();
            Console.WriteLine("Введите число");
            Console.WriteLine();
            
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            
            while (num > 1000 || num < -1000) num/=10;

            Console.WriteLine();
            
            if (num < 0) Console.Write("Третья цифра числа: " + num *-1 % 10);
            else Console.Write("Третья цифра числа: " + num % 10);
            Console.WriteLine();
        }
    }
}

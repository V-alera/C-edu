/*
Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using System;

namespace Seminar_Task1
{
    
    class Program
    {
        static double distanceBetweenTwoPoints (double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));            

            return distance;
        }
        static void Main(string[] args)
        {
            string str;
            double x1 = 0.0, y1 = 0.0, z1 = 0.0, x2 = 0.0, y2 = 0.0, z2 = 0.0, length = 0.0;
            Console.WriteLine();
            Console.WriteLine("Введите значения x, y, z первой точки: ");
                    Console.Write("Значение x1: ");
                    str = Console.ReadLine();
                    x1 = Convert.ToDouble(str);
                    Console.Write("Значение y1: ");
                    str = Console.ReadLine();
                    y1 = Convert.ToDouble(str);
                    Console.Write("Значение z1: ");
                    str = Console.ReadLine();
                    z1 = Convert.ToDouble(str);
            Console.WriteLine();
            Console.WriteLine("Введите значения x, y, z второй точки: ");
                    Console.Write("Значение x2: ");
                    str = Console.ReadLine();
                    x2 = Convert.ToDouble(str);
                    Console.Write("Значение y2: ");
                    str = Console.ReadLine();
                    y2 = Convert.ToDouble(str);
                    Console.Write("Значение z2: ");
                    str = Console.ReadLine();
                    z2 = Convert.ToDouble(str);    
            Console.WriteLine();
                       
                length = distanceBetweenTwoPoints (x1, y1, z1, x2, y2, z2);
            
            Console.WriteLine();

            Console.WriteLine("Расстояние между точками = " + length);
            
            Console.WriteLine();
                       
        }

    }
}

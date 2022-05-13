using System;

namespace Seminar_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0, ostatok = 0;
            Console.WriteLine();
            Console.WriteLine("Введите число");
            Console.WriteLine();
            
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            ostatok = num / 10 % 10;
            
            Console.WriteLine();
            
            Console.Write("Вторая цифра трехзначного числа: " + ostatok);
             
            Console.WriteLine();
        }
    }
}

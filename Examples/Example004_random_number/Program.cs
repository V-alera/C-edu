using System;

namespace Example003_Div
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = new Random().Next(-100000,10000);
            double numberB = new Random().Next(-999999,999999);
            Console.WriteLine();
            Console.Write("Загадано число A = ");
            Console.Write(numberA);
            Console.Write("   Загадано число B = ");
            Console.WriteLine(numberB);
            Console.Write("Деление A/B = ");
            Console.Write(numberA/numberB);
        }
    }
}

using System;

namespace Example001_Hello_console
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Привет. Как тебя зовут?");
            string username = Console.ReadLine();
            Console.Write("Привет, ");
            Console.WriteLine(username);
        }
    }
}

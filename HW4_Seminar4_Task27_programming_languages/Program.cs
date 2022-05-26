using System;

namespace HW4_Seminar4_Task27_programming_languages
{
    class Program
    {
        static int FillData()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int GetResult (int num)
        {
            int res = 0;
            Console.WriteLine($"Суммируем все цифры числа {num}");
            while (num !=0)
            {
                res+=num % 10;
                num/=10;
            }
            return res;
        }
        static void PrintResult (int res)
        {
            Console.WriteLine ($"Сумма цифр составляет: {res}");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int number = FillData();
            int sum = GetResult(number);
                     PrintResult(sum);
        }
    }
}

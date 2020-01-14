using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task11
    {
        public static Boolean IsLeapYear(Int32 year)
        {
            if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
            {
                Console.WriteLine($"Год {year} является високосным");
                return true;
            }
            else
            {
                Console.WriteLine($"Год {year} не является високосным");
                return false;
            }
        }

        public void Run()
        {
            Task11.IsLeapYear(1900);
            Task11.IsLeapYear(2000);
            Task11.IsLeapYear(2020);
        }
    }
}
using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task09
    {
        public static Boolean IsBetween30And100(Int32 x)
        {
            if (x >= 30 && x <= 100)
            {
                Console.WriteLine($"Число {x} в интервале от 30 до 100");
                return true;
            }
            else
            {
                Console.WriteLine($"Число {x} не в интервале от 30 до 100");
                return false;
            }
        }

        public void Run()
        {
            Task09.IsBetween30And100(111);
            Task09.IsBetween30And100(59);
        }
    }
}
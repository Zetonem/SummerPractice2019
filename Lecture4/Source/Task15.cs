using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task15
    {
        public static Int32 Maximum(Int32 a, Int32 b)
        {
            if (a > b)
                return a;
            return b;
        }

        public void Run()
        {
            Console.WriteLine($"Самое большое число из 3 и 15: {Task15.Maximum(3, 15)}");
        }
    }
}
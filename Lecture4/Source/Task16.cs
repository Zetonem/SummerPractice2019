using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task16
    {
        public static Int32 MaximumOf3(Int32 a, Int32 b, Int32 c)
        {
            if (a > b && a > c)
                return a;
            if (b > c)
                return b;
            return c;
        }

        public void Run()
        {
            Console.WriteLine($"Самое большое число из 24, 3 и 15: {Task16.MaximumOf3(24, 3, 15)}");
        }
    }
}
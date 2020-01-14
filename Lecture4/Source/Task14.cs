using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task14
    {
        public static Int32 Minimum(Int32 a, Int32 b)
        {
            if (a < b)
                return a;
            return b;
        }

        public void Run()
        {
            Console.WriteLine($"Самое маленькое число из 3 и 15: {Task14.Minimum(3, 15)}");
        }
    }
}
using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task17
    {
        public static Int32 MinimumOf4(Int32 a, Int32 b, Int32 c, Int32 d)
        {
            Int32 x = Task14.Minimum(a, b);
            Int32 y = Task14.Minimum(c, d);

            return Task14.Minimum(x, y);
        }

        public void Run()
        {
            Console.WriteLine($"Самое маленькое число из 24, 3, 15 и 8: {Task17.MinimumOf4(24, 3, 15, 8)}");
        }
    }
}
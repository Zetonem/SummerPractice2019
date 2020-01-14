using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task18
    {
        public static Int32[] Sort3(Int32 a, Int32 b, Int32 c)
        {
            Int32[] array = {a, b, c};

            for (Int32 i = 0; i < 3; i++)
                for (Int32 j = 0; j < 2; j++)
                    if (array[j] < array[j + 1])
                    {
                        Int32 tmp = array[j + 1];

                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }

            for (Int32 i = 0; i < 3; i++)
                Console.Write($"{array[i]}, ");

            Console.WriteLine();
            return array;
        }

        public void Run()
        {
            Task18.Sort3(0, 1, 7);
        }
    }
}
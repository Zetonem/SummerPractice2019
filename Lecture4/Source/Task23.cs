using System;

namespace SummerPractice2019.Lecture4
{
    public class Task23
    {
        public void Run()
        {
            Int32 i = 0, j = 0;

            while (i++ < 10)
            {
                j = 0;
                while (j++ < 10)
                    Console.Write("Ъ");
                Console.WriteLine();
            }
        }
    }
}
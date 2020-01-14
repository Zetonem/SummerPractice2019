using System;
using System.Runtime.ExceptionServices;

namespace SummerPractice2019.Lecture4
{
    public class Task24
    {
        public void Run()
        {
            for (Int32 i = 1; i <= 10; i++)
            {
                for (Int32 j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
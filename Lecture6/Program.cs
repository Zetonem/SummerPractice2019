using System;
using Common;

namespace SummerPractice2019.Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomLogger.LogStartExample("Lecture 6. Task01.");
            //{
            //    Task01 example = new Task01();

            //    example.Run();
            //    Console.ReadLine();
            //}
            //CustomLogger.LogEndExample();

            //CustomLogger.LogStartExample("Lecture 6. Task02.");
            //{
            //    Task02 example = new Task02();

            //    example.Run();
            //    Console.ReadLine();
            //}
            //CustomLogger.LogEndExample();

            CustomLogger.LogStartExample("Lecture 6. Task03.");
            {
                Task03 example = new Task03();

                example.Run();
                Console.ReadLine();
            }
            CustomLogger.LogEndExample();
        }
    }
}

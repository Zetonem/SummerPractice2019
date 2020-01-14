using System;
using Common;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task21
    {
        public static Int32 MinToSec(Int32 min)
        {
            try
            {
                Int32 res;

                checked
                {
                    res = min * 60;
                }

                return res;
            }
            catch (Exception e)
            {
                CustomLogger.LogException(e);
            }

            return -1;
        }

        public void Run()
        {
            Int32 min = new Random().Next(1000);

            Console.WriteLine($"In {min} minutes {Task21.MinToSec(min)} seconds");
        }
    }
}
using System;
using Common;

namespace SummerPractice2019.Lecture3
{
    internal sealed class Task05
    {
        public void Run()
        {
            Int32 x, y, z;

            try
            {
                Console.Write("Введите 1-е число: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите 2-е число: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите 3-е число: ");
                z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
            }
            catch (Exception e)
            {
                CustomLogger.LogException(e);
            }
        }
    }
}
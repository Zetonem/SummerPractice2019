using System;
using Common;

namespace SummerPractice2019.Lecture3
{
    internal sealed class Task04
    {
        public void Run()
        {
            Int32 x;

            Console.Write("Введите число: ");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Квадрат числа: {x * x}");
            }
            catch (Exception e)
            {
                CustomLogger.LogException(e);
            }
        }
    }
}
using System;
using Common;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task10
    {
        public static Int32 TransformNumber(Int32 x)
        {
            Int32 transformedNumber = x;

            try
            {
                if (x > 0)
                {
                    checked
                    {
                        transformedNumber *= 7;
                    }
                    Console.WriteLine(
                        $"Число {x} положительное, и после трансформации оно станет: {transformedNumber}");
                }
                else if (x < 0)
                {
                    transformedNumber += 7;
                    Console.WriteLine(
                        $"Число {x} отрицательное, и после трансформации оно станет: {transformedNumber}");
                }
                else
                {
                    Console.WriteLine(transformedNumber);
                }
            }
            catch (OverflowException e)
            {
                CustomLogger.LogException(e);
                throw;
            }

            return transformedNumber;
        }
        public void Run()
        {
            Task10.TransformNumber(100);
            Task10.TransformNumber(-10);
            Task10.TransformNumber(0);
        }
    }
}
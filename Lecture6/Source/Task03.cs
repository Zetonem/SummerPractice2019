using System;
using Common;

namespace SummerPractice2019.Lecture6
{
    public static class Calculator
    {
        public static Int32 Sum(Int32 x, Int32 y) => x + y;

        public static Int32 Substraction(Int32 x, Int32 y) => x - y;

        public static Int32 Multiplication(Int32 x, Int32 y) => x * y;

        public static Int32 Sum(params Int32[] numbers)
        {
            Int32 sum = 0;

            try
            {
                for (Int32 i = 0; i < numbers.Length; i++)
                    checked
                    {
                        sum += numbers[i];
                    }
            }
            catch (OverflowException e)
            {
                CustomLogger.LogException(e);
                throw;
            }

            return sum;
        }
    }

    internal sealed class Task03
    {
        public void Run()
        {
            Int32 x = 10, y = 5;

            Console.WriteLine($"{x} + {y} = {Calculator.Sum(x, y)}");
            Console.WriteLine($"{x} - {y} = {Calculator.Substraction(x, y)}");
            Console.WriteLine($"{x} * {y} = {Calculator.Multiplication(x, y)}");
            Console.WriteLine($"1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = {Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");
        }
    }
}
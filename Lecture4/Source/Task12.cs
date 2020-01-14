using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task12
    {
        public static Boolean IsTriangleExist(Int32 a, Int32 b, Int32 c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            return false;
        }
        public void Run()
        {
            if (!Task12.IsTriangleExist(10, 2, 3))
                Console.WriteLine("Треугольник не существует");

            if (Task12.IsTriangleExist(3, 4, 5))
                Console.WriteLine("Треугольник существует");
        }
    }
}
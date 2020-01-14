using System;

namespace SummerPractice2019.Lecture6
{
    public sealed class Task01
    {
        public static Double DistanceBetweenTwoPoints(Double x1, Double y1, Double x2, Double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public void Run()
        {
            Double res = Task01.DistanceBetweenTwoPoints(3, 10, 10, 34);

            Console.WriteLine($"Расстояние между точками (3, 10) и (10, 34) равно {res}");
        }
    }
}
using System;

namespace SummerPractice2019.Lecture6
{
    public class CatTask02
    {
        private static Int32 s_catsCount = 0;

        public static Int32 CatsCount
        {
            get => s_catsCount;
            private set => s_catsCount = value;
        }

        public CatTask02()
        {
            s_catsCount++;
        }
    }
    internal sealed class Task02
    {
        public void Run()
        {
            for (Int32 i = 0; i < 500; i++)
                new CatTask02();

            Console.WriteLine(CatTask02.CatsCount);
        }
    }
}
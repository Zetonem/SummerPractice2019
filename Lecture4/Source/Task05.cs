using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Cat
    {
        public static Int32 InstancesCount { get; private set; }

        public void AddCat()
        {
            InstancesCount++;
        }
    }

    public sealed class Task05
    {
        public void Run()
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            cat1.AddCat();
            cat2.AddCat();
            cat3.AddCat();

            Console.WriteLine($"Количество котов: {Cat.InstancesCount}");
        }
    }
}
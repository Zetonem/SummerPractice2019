using System;

namespace SummerPractice2019.Lecture3
{
    internal sealed class Human
    {
        public String Name;
    }

    internal sealed class Dog
    {
        public Int32 Age;
        public Int32 Weight;
        public const Int32 LegsCount = 4;

        public String Name;
        public String Breed;

        public Human Owner;
    }
    internal sealed class Cat
    {
        public Int32 Age;
        public Int32 Weight;
        public const Int32 LegsCount = 4;

        public String Name;
        public String Breed;

        public Human Owner;
    }

    internal sealed class Task09_11
    {
        public void Run()
        {
            // Create 3 instances of Dog class
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();

            // Make reference from dog2 to dog1
            dog2 = dog1;

            // Create 2 instances of Cat class
            Cat tom = new Cat();
            Cat butch = new Cat();

            butch = null;

            // Create dog and cat owners
            Human catOwner = new Human();
            Human dogOwner = new Human();

            // Set names for owners
            catOwner.Name = "Леонид";
            dogOwner.Name = "Иван";

            // Create dog and cat
            Cat cat = new Cat();
            Dog dog = new Dog();

            // Add owners for pets
            cat.Owner = catOwner;
            dog.Owner = dogOwner;

            System.Console.WriteLine("Владельца кота - зовут: " + cat.Owner.Name);
            System.Console.WriteLine("Владельца собаки - зовут: " + dog.Owner.Name);
        }
    }
}
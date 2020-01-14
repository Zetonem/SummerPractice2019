using System;

namespace SummerPractice2019.Lecture4.RunningCatsTotalizator
{
    // Cat-racer class
    internal sealed class Cat
    {
        public static Int32 s_CatsCount = 10;        // Total cats count

        private static Int32 s_currentCatsCount = 0; // Current count of created cats
        private Int32 _catID;                        // Current cat number
        private Int32 _catSpeed;                     // Current cat speed

        /* Class constructor by speed */
        public Cat(Int32 catSpeed)
        {
            _catSpeed = catSpeed;
            _catID = ++s_currentCatsCount;
        } // End of 'Cat' constructor

        /* Calculate cat running time from start to finish method.
         * ARGUMENTS:
         *   - the race distance:
         *       Int32 distance;
         * RETURNS:
         *   (Double) calculated time.
         */
        public Double ResultTime(Int32 distance) => (Double)(distance) / _catSpeed;
    } // Endof 'Cat' class
} // end of 'SummerPractice2019.Lecture4.RunningCatsTotalizator' namespace

// END OF 'Cat.cs' FILE

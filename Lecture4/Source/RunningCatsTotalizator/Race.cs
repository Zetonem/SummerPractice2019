using System;

namespace SummerPractice2019.Lecture4.RunningCatsTotalizator
{
    // Race manage class
    public sealed class Race
    {
        private readonly Int32 _distance;    // The race distance

        private Double _bestTime;            // Winner time
        private Double _worstTime = -1;               // The worst time it
        private Int32 _bestCatID;            // Winner ID
        private Int32 _playerPrediction;     // Player prediction of race winner

        private readonly Int32 _minCatSpeed; // Minimal cat speed in the race
        private readonly Int32 _maxCatSpeed; // Maximum cat speed in the race
        private readonly Int32 _raceTime;     // Race real time value

        // Class default constructor
        public Race()
        {
            Init();
            _minCatSpeed = 3;
            _maxCatSpeed = 9;
            _distance = 100;
            _raceTime = 10;
        } // End of 'Race' constructor

        /* Initialize race method.
         * ARGUMENTS: None.
         * RETURNS: None.
         */
        public void Init()
        {
            Console.Clear();
            Console.WriteLine("Отлично!!! Забег вот вот начнется, какой номер по вашему" +
                              $"мнению выиграет? Укажите пожалуйста число от 1 до {Cat.s_CatsCount}");

            try
            {
                _playerPrediction = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный символ.");
            }

            _bestCatID = 0;
            _bestTime = Double.MaxValue;
        } // End of 'Init' method

        /* Start race function.
         * ARGUMENTS: None.
         * RETURNS: None.
         */
        public void Run()
        {
            Random rnd = new Random();
            Double[] racersTimes = new Double[Cat.s_CatsCount]; // Racers result times storage

            for (Int32 i = 0; i < Cat.s_CatsCount; i++)
            {
                Int32 racerSpeed = rnd.Next(_minCatSpeed, _maxCatSpeed) * 5;
                Cat racer = new Cat(racerSpeed);

                racersTimes[i] = racer.ResultTime(_distance);

                if (racersTimes[i] <= _bestTime)
                {
                    _bestCatID = i + 1;
                    _bestTime = racersTimes[i];
                }

                if (_worstTime < racersTimes[i])
                    _worstTime = racersTimes[i];
            }

            /* Time processing data block */
            var curTime = DateTime.Now;                      // Current OS time
            var deltaTime = DateTime.Now.Subtract(curTime);  // Delta time to output race data
            var globalTime = DateTime.Now.Subtract(curTime); // Race current time

            Double[] racersRealTimes = new Double[Cat.s_CatsCount + 1]; // Real racers times

            // Fill racers real time
            for (Int32 i = 0; i < Cat.s_CatsCount; i++)
                racersRealTimes[i] = racersTimes[i] * _raceTime / _worstTime;

            Console.Clear();

            Boolean isRaceEnd = false;

            // Draw cats
            while (!isRaceEnd)
            {
                if (deltaTime.Milliseconds > 300)
                {
                    Console.Clear();
                    Console.WriteLine($"Race time: {globalTime.Seconds} seconds");

                    // Follow for all racers
                    for (Int32 j = 0; j < Cat.s_CatsCount; j++)
                    {
                        // If the best cat crossed the finish line stop the race
                        if (globalTime.Seconds >= racersRealTimes[_bestCatID - 1])
                        {
                            isRaceEnd = true;
                        }

                        /* Draw cats route */
                        Console.WriteLine($"{j + 1}.");

                        for (Int32 i = 0; i < globalTime.Seconds * _raceTime / racersRealTimes[j]; i++)
                            Console.Write("==");

                        Console.WriteLine();
                    }

                    // Reset delta time
                    deltaTime = DateTime.Now.Subtract(curTime);
                }

                /* Update time data */
                curTime = DateTime.Now;
                deltaTime += DateTime.Now.Subtract(curTime);
                globalTime += DateTime.Now.Subtract(curTime);
            }

            WriteResult();
            WritePredictionResult();
        } // End of 'Run' method

        /* Display race result on the screen method.
        * ARGUMENTS: None.
        * RETURNS: None.
        */
        private void WriteResult() => 
            Console.WriteLine($"Победил кот под номером: {_bestCatID}, пробежав дистанцию за = {_bestTime * _raceTime / _worstTime} секунд!");

        /* Display prediction result on the screen method.
         * ARGUMENTS: None.
         * RETURNS: None.
         */
        private void WritePredictionResult()
        {
            if (_playerPrediction == _bestCatID)
            {
                Console.WriteLine("ПОЗДРАВЛЯЕМ!!! Вы угадали!");
                Console.WriteLine("Спасибо за игру! До встречи");
            }
            else
            {
                Console.WriteLine("Очень жаль, но вы проиграли!");
                Console.WriteLine("В следующий раз непременно повезет! До встречи!");
            }
        } // End of 'WritePredictionResult' method
    } // End of 'Race' class
} // end of 'SummerPractice2019.Lecture4.RunningCatsTotalizator' namespace

// END OF 'Race.cs' class

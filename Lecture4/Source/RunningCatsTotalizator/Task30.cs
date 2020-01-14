using System;
using Common;

namespace SummerPractice2019.Lecture4.RunningCatsTotalizator
{
    public sealed class Task30
    {
        public void Run()
        {
            try
            {
                SRaceIO.StartMenu();
            }
            catch (Exception e)
            {
                CustomLogger.LogException(e);
                throw;
            }
        }
    } // End of 'Task30' class
} // end of 'SummerPractice2019.Lecture4.RunningCatsTotalizator' namespace

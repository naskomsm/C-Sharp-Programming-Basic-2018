using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalDistance = 0; // km
            double calories = 0;
            double totalTime = 0; // mins
            double totalCalories = 0;

            for (int i = 0; i < days; i++)
            {
                int runningTime = int.Parse(Console.ReadLine());
                double distanceForDay = double.Parse(Console.ReadLine());
                string unit = Console.ReadLine();

                if(unit == "m") distanceForDay = distanceForDay / 1000;
                if (runningTime == 20) calories = 400;
                else if (runningTime != 20) calories = runningTime * 20;
               
                totalDistance = totalDistance + distanceForDay;
                totalTime = totalTime + runningTime;
                totalCalories = totalCalories + calories;

            }

            Console.WriteLine($"He ran {totalDistance:f2}km for {totalTime} minutes and burned {totalCalories} calories.");
            






        }
    }
}

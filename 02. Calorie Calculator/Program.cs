using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string physicalActivity = Console.ReadLine().ToLower();

            double heightInCM = height * 100;
            double BNMforMen = 66 + (13.7 * weight) + (5 * heightInCM) - (6.8 * age);
            double BNMforWomen = 655 + (9.6 * weight) + (1.8 * heightInCM) - (4.7 * age);
            double coef = 0;
            double calories = 0;

            if (gender == "m")
            {
                if (physicalActivity == "sedentary")
                {
                    coef = 1.2;
                    calories = BNMforMen * coef;
                }
                else if (physicalActivity == "lightly active")
                {
                    coef = 1.375;
                    calories = BNMforMen * coef;
                }
                else if (physicalActivity == "moderately active")
                {
                    coef = 1.55;
                    calories = BNMforMen * coef;
                }
                else if (physicalActivity == "very active")
                {
                    coef = 1.725;
                    calories = BNMforMen * coef;
                }
            }
            else if (gender == "f")
            {
                if (physicalActivity == "sedentary")
                {
                    coef = 1.2;
                    calories = BNMforWomen * coef;
                }
                else if (physicalActivity == "lightly active")
                {
                    coef = 1.375;
                    calories = BNMforWomen * coef;
                }
                else if (physicalActivity == "moderately active")
                {
                    coef = 1.55;
                    calories = BNMforWomen * coef;
                }
                else if (physicalActivity == "very active")
                {
                    coef = 1.725;
                    calories = BNMforWomen * coef;
                }
            }

            calories = Math.Ceiling(calories);
            Console.WriteLine($"To maintain your current weight you will need {calories} calories per day. ");
        }
    }
}

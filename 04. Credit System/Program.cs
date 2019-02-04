using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double overallCredits = 0;

            for (int i = 1; i <= n; i++)
            {
                int creditsAndGrade = int.Parse(Console.ReadLine());
                int grade = creditsAndGrade % 10;
                double credits = creditsAndGrade / 10;
                sum = sum + grade;

                switch (grade)
                {
                    case 2:
                        credits = 0;
                        break;
                    case 3:
                        credits = credits * 0.50;
                        break;
                    case 4:
                        credits = credits * 0.70;
                        break;
                    case 5:
                        credits = credits * 0.85;
                        break;
                    case 6:
                        credits = credits * 1;
                        break;
                }

                overallCredits = overallCredits + credits;

            }
            double averageGrade = sum / n;
            Console.WriteLine($"{overallCredits:f2}");
            Console.WriteLine($"{averageGrade:f2}");

        }
    }
}

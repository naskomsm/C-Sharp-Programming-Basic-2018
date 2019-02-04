using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnnualSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int experience = int.Parse(Console.ReadLine());
            string specialty = Console.ReadLine();
            double salary = 0;
            if (specialty == "C# Developer")
                salary = 5400;
            else if (specialty == "Java Developer")
                salary = 5700;
            else if (specialty == "Front-End Web Developer")
                salary = 4100;
            else if (specialty == "UX / UI Designer")
                salary = 3100;
            else if (specialty == "Game Designer")
                salary = 3600;

            if (experience <= 5)
                salary = salary - salary * 0.658;

            double yearIncome = 12 * salary;
            Console.WriteLine($"Total earned money: {yearIncome:f2} BGN");
        }
    }
}
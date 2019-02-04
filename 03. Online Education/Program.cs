using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Education
{
    class Program
    {
        static void Main(string[] args)
        {
            int onlineSum = 0;
            int onsiteSum = 0;
            int sum = 0;


            // Predvaritelno
            string inadvanceEducationform = Console.ReadLine();
            int inadvanceStudents = int.Parse(Console.ReadLine());
            // Redovno
            string regularlyEducationform = Console.ReadLine();
            int regularStudents = int.Parse(Console.ReadLine());
            // Kasno
            string lateEducationform = Console.ReadLine();
            int lateStudents = int.Parse(Console.ReadLine());



            // Predvaritelno
            if (inadvanceEducationform == "online")
            {
                onlineSum = onlineSum + inadvanceStudents;
                sum = onlineSum + onsiteSum;
            }
            else if (inadvanceEducationform == "onsite")
            {
                onsiteSum = onsiteSum + inadvanceStudents;
                sum = onlineSum + onsiteSum;
            }

            // Redovno
            if (regularlyEducationform == "online")
            {
                onlineSum = onlineSum + regularStudents;
                sum = onlineSum + onsiteSum;
            }
            else if (regularlyEducationform == "onsite")
            {
                onsiteSum = onsiteSum + regularStudents;
                sum = onlineSum + onsiteSum;
            }

            // Kasno
            if (lateEducationform == "online")
            {
                onlineSum = onlineSum + lateStudents;
                sum = onlineSum + onsiteSum;
            }
            else if (lateEducationform == "onsite")
            {
                onsiteSum = onsiteSum + lateStudents;
                sum = onlineSum + onsiteSum;
            }

            // if online students > 600 ....
            if (onsiteSum > 600)
            {
                int remainderOfonsiteSum = onsiteSum - 600;
                onsiteSum = onsiteSum - remainderOfonsiteSum;
                onlineSum = onlineSum + remainderOfonsiteSum;
            }


            Console.WriteLine($"Online students: {onlineSum}");
            Console.WriteLine($"Onsite students: {onsiteSum}");
            Console.WriteLine($"Total students: {sum}");

        }
    }
}

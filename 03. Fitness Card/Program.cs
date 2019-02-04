using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char gander = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double totalMoney = 0;

            if (gander == 'm' && (money >= 10 && money <= 1000))
            {
                switch (sport)
                {
                    case "Gym":
                        totalMoney = 42;
                        break;
                    case "Boxing":
                        totalMoney = 41;
                        break;
                    case "Yoga":
                        totalMoney = 45;
                        break;
                    case "Zumba":
                        totalMoney = 34;
                        break;
                    case "Dances":
                        totalMoney = 51;
                        break;
                    case "Pilates":
                        totalMoney = 39;
                        break;
                }

            }

            else if (gander == 'f' && (money >= 10 && money <= 1000))
            {
                switch (sport)
                {
                    case "Gym":
                        totalMoney = 35;
                        break;
                    case "Boxing":
                        totalMoney = 37;
                        break;
                    case "Yoga":
                        totalMoney = 42;
                        break;
                    case "Zumba":
                        totalMoney = 31;
                        break;
                    case "Dances":
                        totalMoney = 53;
                        break;
                    case "Pilates":
                        totalMoney = 37;
                        break;
                }
            }

            if (age <= 19)
            {
                totalMoney = totalMoney - totalMoney * 0.2;
            }

            if (totalMoney <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:f2} more.", totalMoney - money);
            }
        }
    }
}

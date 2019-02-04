using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOnePage = double.Parse(Console.ReadLine());
            double priceForOneCover = double.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());
            double sumToPay = double.Parse(Console.ReadLine());
            int percentagePayedByTeam = int.Parse(Console.ReadLine());

            double bookPrice = priceForOnePage * 899 + priceForOneCover * 2;
            double afterDiscount = bookPrice - bookPrice * (double)percentageDiscount / 100;


            double forTheDesigner = afterDiscount + sumToPay;
            double finalPriceToPay = forTheDesigner - forTheDesigner * (double)percentagePayedByTeam / 100;

            Console.WriteLine($"Avtonom should pay {finalPriceToPay:f2} BGN.");


        }
    }
}

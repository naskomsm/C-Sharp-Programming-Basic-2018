using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForFood = double.Parse(Console.ReadLine());
            double priceForjewellery = double.Parse(Console.ReadLine());
            double priceForHotel = double.Parse(Console.ReadLine());

            double distance = 210 * 2; // zashtoto 210 e za otivane i 210 za vrashtane
            double duration = 3;
            double priceOfFuel = 1.85;
            // double totalPrice;
            // first day they get 10% discount
            // second day they got 15% discount
            // third day they got 20% discount

            double FuelLiters = distance / 100 * 7; // 29.4
            double FuelPrice = FuelLiters * priceOfFuel; // 54.39
            double FoodandJewelleryPrice = duration * priceForFood + duration * priceForjewellery; // 450

            double firstDay = priceForHotel * 0.9; // 450
            double secondDay = priceForHotel * 0.85; // 425
            double thirdDay = priceForHotel * 0.8; // 400

            double totalPrice = FuelPrice + FoodandJewelleryPrice + firstDay + secondDay + thirdDay;
            Console.WriteLine($"Money needed: {totalPrice}");




        }
    }
}

using System;
using DairyProductsMVC.Model;

namespace DairyProductsMVC.Views
{
    public class Display
    {
        // Method to get input from the user
        public DairyProducts GetDataFromUser()
        {
            Console.Write("Enter cheese price per kg: ");
            double cheesePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter butter price per kg: ");
            double butterPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter total kg of cheese: ");
            int cheeseQuantity = int.Parse(Console.ReadLine());

            Console.Write("Enter total kg of butter: ");
            int butterQuantity = int.Parse(Console.ReadLine());

            // Create a model instance using the constructor
            return new DairyProducts(cheesePrice,butterPrice,cheeseQuantity,butterQuantity);
        }

        // Method to display the total income in euros
        public void DisplayTotalIncome(double totalIncome)
        {
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}

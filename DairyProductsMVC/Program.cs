using System;
using DairyProductsMVC.Controllers;
using DairyProductsMVC.Views;

namespace DairyProductsMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Display view = new Display(); // Create an instance of the view
            DairyController controller = new DairyController(view); // Pass the view to the controller

            controller.ProcessAndDisplayIncome(); // Execute the logic to process and display income
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

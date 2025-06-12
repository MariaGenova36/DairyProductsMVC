namespace DairyProductsMVC.Model
{
    public class DairyProducts
    {
        public double CheesePrice { get; set; }
        public double ButterPrice { get; set; }
        public int CheeseQuantity { get; set; }
        public int ButterQuantity { get; set; }


        public DairyProducts(double cheesePrice,double butterPrice,int cheeseQuantity,int butterQuantity)
        {
            CheesePrice = cheesePrice;
            ButterPrice = butterPrice;
            CheeseQuantity = cheeseQuantity;
            ButterQuantity=butterQuantity;
        }
        // Method to calculate total income in leva
        public double CalculateTotalIncome()
        {
            double totalIncome = (CheesePrice * CheeseQuantity) + (ButterPrice * ButterQuantity);
            return totalIncome;
        }
    }
}

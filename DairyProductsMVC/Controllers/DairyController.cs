using DairyProductsMVC.Views;
using DairyProductsMVC.Model;


namespace DairyProductsMVC.Controllers
{
    public class DairyController
    {
        private DairyProducts _model;
        private Display _view;

        public DairyController(Display view)
        {
            _view = view;
            _model = _view.GetDataFromUser();
        }
        // Method to process and display the income
        public void ProcessAndDisplayIncome()
        {
            double totalIncome = _model.CalculateTotalIncome();
            _view.DisplayTotalIncome(totalIncome);
        }
    }
}

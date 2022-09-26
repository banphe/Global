using MVM.MafiaFiles.Model;
using System.Collections.ObjectModel;
using System;
namespace MVM.MafiaFiles.ViewModel
{
    public class WeedSalesViewModel : ObservableCollection<WeedSale>
    {
        public string Name { get; set; }
        public WeedSalesViewModel()
        {
            Name = "Weed Sales";
            Add("Bruce Banner", "High Quen", DateTime.Now.AddDays(-55), 29000, 100);
            Add("Bruce Banner", "Michael", DateTime.Now.AddDays(-3), 1500, 3);
        }
        public void Add(string harvestValue, string customerValue, DateTime dateValue, int incomeValue, int weightValue)
        {
            Add(new WeedSale(harvestValue, customerValue, dateValue, incomeValue, weightValue));

        }
    }
}

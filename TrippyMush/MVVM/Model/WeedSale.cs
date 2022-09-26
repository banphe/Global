using TrippyMush.Core;
using System;


namespace TrippyMush.MVVM.Model
{
    public class WeedSale : ObservableObject
    {
        private string _harvest;
        private string _customer;
        private DateTime _date;
        private int _income;
        private int _weight;

        public string Harvest
        {
            get { return _harvest; }
            set
            {
                _harvest = value;
                OnPropertyChanged();
            }
        }
        public string Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }
        public int Income
        {
            get { return _income; }
            set
            {
                _income = value;
                OnPropertyChanged();
            }
        }
        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }
        public WeedSale(string harvestValue, string customerValue, DateTime dateValue, int incomeValue,int weightValue)
        {
           Harvest = harvestValue;
           Customer = customerValue;
           Date = dateValue;
           Income = incomeValue;
           Weight = weightValue;
        }
    }


}

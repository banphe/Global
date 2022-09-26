//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Live
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    
    public partial class Bilans : INotifyPropertyChanged
    {
        public Bilans()
        {
            this.Salaries = new ObservableCollection<Salary>();
            this.WeedSales = new ObservableCollection<WeedSale>();
            this.CompanyPurchases = new ObservableCollection<CompanyPurchase>();
            this.CapitalInvestments = new ObservableCollection<CapitalInvestment>();
        }
    
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set
            {
                if (_Id != value)
                {
                    _Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private string _Property1;
        public string Property1
        {
            get { return _Property1; }
            set
            {
                if (_Property1 != value)
                {
                    _Property1 = value;
                    OnPropertyChanged("Property1");
                }
            }
        }
    
        private ObservableCollection<Salary> _Salaries;
        public ObservableCollection<Salary> Salaries
        {
            get { return _Salaries; }
            set
            {
                if (_Salaries != value)
                {
                    _Salaries = value;
                    OnPropertyChanged("Salaries");
                }
            }
        }
        private ObservableCollection<WeedSale> _WeedSales;
        public ObservableCollection<WeedSale> WeedSales
        {
            get { return _WeedSales; }
            set
            {
                if (_WeedSales != value)
                {
                    _WeedSales = value;
                    OnPropertyChanged("WeedSales");
                }
            }
        }
        private ObservableCollection<CompanyPurchase> _CompanyPurchases;
        public ObservableCollection<CompanyPurchase> CompanyPurchases
        {
            get { return _CompanyPurchases; }
            set
            {
                if (_CompanyPurchases != value)
                {
                    _CompanyPurchases = value;
                    OnPropertyChanged("CompanyPurchases");
                }
            }
        }
        private ObservableCollection<CapitalInvestment> _CapitalInvestments;
        public ObservableCollection<CapitalInvestment> CapitalInvestments
        {
            get { return _CapitalInvestments; }
            set
            {
                if (_CapitalInvestments != value)
                {
                    _CapitalInvestments = value;
                    OnPropertyChanged("CapitalInvestments");
                }
            }
        }
    
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        #endregion
    }
}

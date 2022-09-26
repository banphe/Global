using TrippyMush.MVVM.Model;
using TrippyMush.Core;
namespace TrippyMush.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentVM;
        public RelayCommand AddCustomerButtonClicked { get; set; }
        public  RelayCommand CustomerTabClicked { get; set; }
        public RelayCommand WeedSalesTabClicked { get; set; }
   
        public CustomersViewModel CustomersVM { get; set; }
   
        public WeedSalesViewModel WeedSalesVM { get; set; }
       
        public object CurrentVM { get {return _currentVM; }
        }
        public MainViewModel()
        {
          
            CustomersVM = new CustomersViewModel();
            WeedSalesVM = new WeedSalesViewModel();
       
            _currentVM = WeedSalesVM;
            OnPropertyChanged("CurrentVM");
            AddCustomerButtonClicked = new RelayCommand(o =>
            {
                CustomersVM.Add(new Customer("Dynamic", true));
            });
            WeedSalesTabClicked = new RelayCommand(o =>
            {
                _currentVM = WeedSalesVM;
                OnPropertyChanged("CurrentVM");
            });
            CustomerTabClicked = new RelayCommand(o =>
            {
                _currentVM = CustomersVM;
                OnPropertyChanged("CurrentVM");
            });
        }
    }
}
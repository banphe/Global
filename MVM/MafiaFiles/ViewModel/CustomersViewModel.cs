using MVM.MafiaFiles.Model;
using System.Collections.ObjectModel;
namespace MVM.MafiaFiles.ViewModel
{
        public class CustomersViewModel : ObservableCollection<Customer>
    {
            public string Name { get; set; }
            public CustomersViewModel()
            {
            Name = "Customers";
            Add(new Customer("Queeen", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Customer("Zygfryd", false));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Customer("Friend From irish Dude", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Customer("Adam", false));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Customer("Chiang Mai Hospital", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Customer("D-Condo", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
        }

        }
}

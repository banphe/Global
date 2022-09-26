using TrippyMush.MVVM.Model;
using System.Collections.ObjectModel;
namespace TrippyMush.MVVM.ViewModel
{
    public class SeedsViewModel : ObservableCollection<Seed>
    {
        public string Name { get; set; }
        public SeedsViewModel()
        {
            Name = "Seds";
            Add(new Seed("Hulkbery", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Seed("Purple Lemonade", true));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Seed("Foster", false));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new Seed("Foster", false));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
        }

    }
}

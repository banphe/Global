
using System.Collections.ObjectModel;
namespace ClassFactory
{
        public class DiagramObjectViewModel : ObservableCollection<DiagramObject>
    {
            public string Name { get; set; }
            public DiagramObjectViewModel()
            {
            Name = "Customers";
            Add(new DiagramObject("Person", 10,0));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new DiagramObject("Car", 10, 100));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new DiagramObject("Task", 10, 200));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
            Add(new DiagramObject("Box", 10, 300));
            OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Add)));
  
        }

        }
}

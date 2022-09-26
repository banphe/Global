namespace ClassFactory
{
    public class MainViewModel : ObservableObject
    {
       
     
        public RelayCommand AddCustomerButtonClicked { get; set; }
        public RelayCommand CustomerTabClicked { get; set; }
        public DiagramObjectViewModel DiagramObjectVM { get; set; }
        public string Title { get { return "asdfjj"; } }
     
        public MainViewModel()
        {
            DiagramObjectVM = new DiagramObjectViewModel();
         
            AddCustomerButtonClicked = new RelayCommand(o =>
            {
                DiagramObjectVM.Add(new DiagramObject("Dynamic", 55,55));
            });
         
         
        }
    }
}


namespace ClassFactory
{
    public class DiagramObject : ObservableObject
    {
        private int _y;
        private int _x; 
        private string _name;
        private bool _fromChiangMai;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged ();  
            }
        }
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged();
            }
        }
        public DiagramObject(string nameValue, int y, int x)
        {
            Name = nameValue;
            Y = y;
            X = x;
        }
    }
}

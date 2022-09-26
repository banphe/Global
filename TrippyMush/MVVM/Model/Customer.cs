using TrippyMush.Core;

namespace TrippyMush.MVVM.Model
{
    public class Customer : ObservableObject
    {
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
        public bool FromChiangMai
        {
            get { return _fromChiangMai; }
            set
            {
                _fromChiangMai = value;
            }
        }
        public Customer(string nameValue, bool isFromCHiangMaiValue)
        {
            Name = nameValue;
            FromChiangMai = isFromCHiangMaiValue;
        }
    }
}

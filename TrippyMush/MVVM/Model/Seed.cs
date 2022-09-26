using TrippyMush.Core;


namespace TrippyMush.MVVM.Model
{
    public class Seed : ObservableObject
    {
        private string _strddddddain;
        private string _strain;
        private bool _isAutoflowering;

        public Seed(string strain, bool isAutoflowering)
        {
            Strain = strain;
            IsAutoflowering = isAutoflowering;
        }

        public string Strain
        {
            get { return _strain; }
            set
            {
                _strain = value;
                OnPropertyChanged();
            }
        }
        public bool IsAutoflowering
        {
            get { return _isAutoflowering; }
            set
            {
                _isAutoflowering = value;
            }
        }

    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrippyMush.Core
{
    public class ObservableObject : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
         

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}

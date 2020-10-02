using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Example
{
    public abstract class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nameProperty = null)=>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
    }
}

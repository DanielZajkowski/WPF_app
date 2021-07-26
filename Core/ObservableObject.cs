using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModernDesign.Core
{
    // INotifyPropertyChanged - mainly use to updating the ui when binding
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

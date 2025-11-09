using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QMS.VirtualTerminal.Helpers;

public abstract class ObservableProperty : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
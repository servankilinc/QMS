using QMS.VirtualTerminal.Helpers;

namespace QMS.VirtualTerminal.ViewModels;

public class MainWindowVM : BaseViewModel
{
    private BaseViewModel _currentView;
    public BaseViewModel CurrentView
    {
        get => _currentView;
        private set
        {
            if (_currentView == value) return;
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainWindowVM(HomeVM homeVM)
    {
        _currentView = homeVM;
        CurrentView = homeVM;
    }
}
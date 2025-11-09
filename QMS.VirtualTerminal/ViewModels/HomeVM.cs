using QMS.VirtualTerminal.Helpers;
using System.Windows.Input;

namespace QMS.VirtualTerminal.ViewModels;

public class HomeVM : BaseViewModel
{
    private string _title = "Welcome to QMS Kiosk Home Page";
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            OnPropertyChanged();
        }
    }
    public ICommand TitleChangeCommand { get; private set; }

    public HomeVM()
    {
        TitleChangeCommand = new RelayCommand(o =>
        {
            Title = "Home Title Changed!";
        });
    }
}
using QMS.VirtualTerminal.ViewModels;
using System.Windows;

namespace QMS.VirtualTerminal.Views;

public partial class MainWindow : Window
{
    public MainWindow(MainWindowVM viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}

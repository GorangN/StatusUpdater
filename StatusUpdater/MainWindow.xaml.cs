using System.Windows;

namespace StatusUpdater;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = ((App)Application.Current).DashboardVm;
    }
}

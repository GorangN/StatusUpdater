using System.Windows;
using StatusUpdater.ViewModels;

namespace StatusUpdater;
public partial class App : Application
{
    public DashboardViewModel DashboardVm { get; } = new();
}
